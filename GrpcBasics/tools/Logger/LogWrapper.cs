using System;

namespace XFrame.Common.Api.Logger
{
    public class LogWrapper
    {
        private Type _Type;
        public LogWrapper(Type t)
        {
            _Type = t;
        }
        public ILogger Log()
        {
            var log = DependencyInjectionHelper.Resolver.GetExportedValue<ILogManager>().GetLogger(_Type);
            return log;
        }
    }
}