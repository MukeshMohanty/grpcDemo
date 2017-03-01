using Google.Protobuf;
using Grpc.Core;
using Grpc.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Grpc.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = int.Parse(args[0]);
            const int port = 9000;
            var cacert = File.ReadAllText(@"ca.crt");
            var cert = File.ReadAllText(@"client.crt");
            var key = File.ReadAllText(@"client.key");
            var keypair = new KeyCertificatePair(cert, key);
            var creds = new SslCredentials(cacert, keypair);
            var channel = new Channel("NKMN-PC", port, creds);
            var client = new EmployeeService.EmployeeServiceClient(channel);
            switch (option)
            {
                case 1:
                    SendMetadataAsync(client).Wait();
                    break;
                case 2:
                    GetByBadgeNumberAsync(client).Wait();
                    break;
                case 3:
                    GetAllAsync(client).Wait();
                    break;
                case 4:
                    AddPhotoRequestAsync(client).Wait();
                    break;
                case 5:
                    SaveAllAsync(client).Wait();
                    break;
            }
            Console.ReadLine();
        }

        private static async Task SaveAllAsync(EmployeeService.EmployeeServiceClient client)
        {
            var employees = new List<Employee>
            {
                new Employee {BadgeNumber = 2, FirstName = "Sunny", LastName = "Hook", Id = 22, VacationAccurateRate = 2.1F, VacationAccured = 1.2F},
                new Employee {BadgeNumber = 3, FirstName = "Cheese", LastName = "Burger", Id = 33, VacationAccurateRate = 2.1F, VacationAccured = 1.2F}
            };
            using (var call = client.SaveAll())
            {
                var requestStream = call.RequestStream;
                var responseStream = call.ResponseStream;
                var responseTask = Task.Run(async () =>
                {
                    while (await responseStream.MoveNext())
                    {
                        Console.WriteLine("Saved: " + responseStream.Current.Employee);
                    }
                });
                foreach (var e in employees)
                {
                    await requestStream.WriteAsync(new EmployeeRequest { Employee = e });
                }
                await requestStream.CompleteAsync();
                await responseTask; //order is important.
            }
        }

        private static async Task AddPhotoRequestAsync(EmployeeService.EmployeeServiceClient client)
        {
            var md = new Metadata();
            md.Add("badgenumber", "1");
            var fs = File.OpenRead(@"emp.jpg");
            using (var call = client.AddPhoto(md))
            {
                var stream = call.RequestStream;
                while (true)
                {
                    var buffer = new byte[64 * 1024];
                    int numRead = await fs.ReadAsync(buffer, 0, buffer.Length);
                    if (numRead == 0)
                        break;
                    if (numRead < buffer.Length)
                        Array.Resize(ref buffer, numRead);
                    await stream.WriteAsync(new AddPhotoRequest { Data = ByteString.CopyFrom(buffer) });
                }
                await stream.CompleteAsync();
                var res = await call.ResponseAsync;
                Console.WriteLine(res.IsOk);
            }
        }

        private static async Task GetAllAsync(EmployeeService.EmployeeServiceClient client)
        {
            using (var call = client.GetAll(new GetAllRequest()))
            {
                var responseStream = call.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    Console.WriteLine(responseStream.Current.Employee);
                }
            }
        }

        private static async Task SendMetadataAsync(EmployeeService.EmployeeServiceClient client)
        {
            var md = new Metadata { { "username", "kummsha" }, { "password", "123456" } };
            try
            {
                await client.GetByBadgeNumberAsync(new GetByBadgeNumberRequest(), md);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static async Task GetByBadgeNumberAsync(EmployeeService.EmployeeServiceClient client)
        {
            try
            {
                var res = await client.GetByBadgeNumberAsync(new GetByBadgeNumberRequest() { BadgeNumber = 1 });
                Console.WriteLine(res.Employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
