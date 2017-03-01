using System;

namespace XFrame.Common.Api.Logger
{
    public interface ILogManager
    {
        ILogger GetLogger(Type type);
        ILogger GetLogger(string loggerName);
    }
}