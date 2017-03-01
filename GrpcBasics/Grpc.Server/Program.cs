using Grpc.Core;
using Grpc.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Grpc.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 9000;
            var cacert = File.ReadAllText(@"ca.crt");
            var cert = File.ReadAllText(@"server.crt");
            var key = File.ReadAllText(@"server.key");

            var keypair = new KeyCertificatePair(cert, key);
            var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair> { keypair }, cacert, false);

            var server = new Core.Server
            {
                Ports = { new ServerPort("0.0.0.0", port, sslCredentials) },
                Services = { Messages.EmployeeService.BindService(new EmployeeService()) }
            };
            server.Start();
            Console.WriteLine("Starting server ..");
            Console.ReadLine();
            server.ShutdownAsync().Wait();
        }

        public class EmployeeService : Messages.EmployeeService.EmployeeServiceBase
        {
            public override async Task<EmployeeResponse> GetByBadgeNumber(GetByBadgeNumberRequest request, ServerCallContext context)
            {
                Metadata md = context.RequestHeaders;
                foreach (var entry in md)
                {
                    Console.WriteLine(entry.Key + ":" + entry.Value);
                }
                foreach (var e in Employees.EmployeeList)
                {
                    if (e.BadgeNumber == request.BadgeNumber)
                        return new EmployeeResponse { Employee = e };
                }
                throw new Exception("Not found!!");
            }

            public override async Task GetAll(GetAllRequest request, IServerStreamWriter<EmployeeResponse> responseStream, ServerCallContext context)
            {
                foreach (var employee in Employees.EmployeeList)
                {
                    await responseStream.WriteAsync(new EmployeeResponse()
                    {
                        Employee = employee
                    });
                }
            }

            public override async Task<AddPhotoResponse> AddPhoto(IAsyncStreamReader<AddPhotoRequest> requestStream, ServerCallContext context)
            {
                Metadata md = context.RequestHeaders;
                foreach (var entry in md)
                {

                }

                var data = new List<byte>();
                while (await requestStream.MoveNext())
                {
                    Console.WriteLine("Received " + requestStream.Current.Data.Length + " bytes");
                    data.AddRange(requestStream.Current.Data);
                }
                Console.WriteLine("Received file with " + data.Count + " bytes");

                return new AddPhotoResponse
                {
                    IsOk = true
                };
            }

            public override async Task SaveAll(IAsyncStreamReader<EmployeeRequest> requestStream, IServerStreamWriter<EmployeeResponse> responseStream, ServerCallContext context)
            {
                while (await requestStream.MoveNext())
                {
                    var employee = requestStream.Current.Employee;
                    lock (this)
                    {
                        Employees.EmployeeList.Add(employee);
                    }

                    await responseStream.WriteAsync(new EmployeeResponse
                    {
                        Employee = employee
                    });
                }
                Console.WriteLine("Employees");
                foreach (var e in Employees.EmployeeList)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }

    internal class Employees
    {
        public static List<Employee> EmployeeList = new List<Employee>
        {
            new Employee {BadgeNumber = 1, FirstName = "Mukesh", LastName = "Mohanty", Id = 11, VacationAccurateRate = 2.1F, VacationAccured = 1.2F}
        };
    }
}
