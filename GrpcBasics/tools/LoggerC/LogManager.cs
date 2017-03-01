using System;
using System.Linq;
using System.ComponentModel.Composition;
using XFrame.Common.Api.Logger;
using XFrame.Common.Api.Providers;
using XFrame.Common.Api.Constants;

namespace XFrame.Common.Logger
{
  [Export(typeof(ILogManager))]
  [PartCreationPolicy(CreationPolicy.Shared)]
  public class LogManager : ILogManager
  {
    [Import(RequiredCreationPolicy = CreationPolicy.Shared)]
    protected static IConfigurationPropertiesProvider _ConfigurationPropertiesProvider;

    static readonly ILogManager _logManager;

    static LogManager()
    {
      //string path = ConfigurationManager.AppSettings["Logger"];
      log4net.Config.XmlConfigurator.Configure();//.Configure(new FileInfo(path));
      _logManager = new LogManager();
    }

    public static ILogger GetLogger<T>()
    {
      return _logManager.GetLogger(typeof(T));
    }

    public ILogger GetLogger(Type type)
    {
      var logger = log4net.LogManager.GetLogger(type);
      return new LoggerAdapter(logger);
    }

    public ILogger GetLogger(string loggerName)
    {
        var logger = log4net.LogManager.GetLogger(loggerName);
        return new LoggerAdapter(logger);
    }
  }
}