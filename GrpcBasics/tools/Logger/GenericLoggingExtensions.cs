using System.Windows.Forms;

namespace XFrame.Common.Api.Logger
{
    public static class GenericLoggingExtensions
    {      
        public static ILogger Log<T>(this T thing)
        {            
            var log = DependencyInjectionHelper.Resolver.GetExportedValue<ILogManager>().GetLogger(typeof(T));
            return log;
        }
        public static ILogger Log<T>(this T thing, string loggerName)
        {
            var log = DependencyInjectionHelper.Resolver.GetExportedValue<ILogManager>().GetLogger(loggerName);
            return log;
        }
    }
}