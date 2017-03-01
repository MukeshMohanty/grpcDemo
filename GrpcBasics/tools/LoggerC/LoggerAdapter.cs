using System;
using log4net;
using XFrame.Analytics.Api.Providers;
using XFrame.Common.Api;
using XFrame.Common.Api.Logger;

namespace XFrame.Common.Logger
{
    public class LoggerAdapter : ILogger
    {
        private IAnalyticsFeatureProvider _AnalyticsFeatureProvider;
        private readonly ILog _log;

        internal LoggerAdapter(ILog log)
        {
            try
            {
                _AnalyticsFeatureProvider = DependencyInjectionHelper.Resolver.GetExportedValue<IAnalyticsFeatureProvider>();
            }
            catch (Exception)
            {
                //todo: Proper impl
            }
            _log = log;
        }

        public void Debug(object message)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.Debug(message, exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.DebugFormat(format, args);
        }

        public void DebugFormat(string format, object arg0)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.DebugFormat(format, arg0);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.DebugFormat(format, arg0, arg1);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.DebugFormat(format, arg0, arg1, arg2);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.DebugFormat(provider, format, args);
        }

        public void Info(object message)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.Info(message, exception);
        }

        public void InfoFormat(string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.InfoFormat(format, args);
        }

        public void InfoFormat(string format, object arg0)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.InfoFormat(format, arg0);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.InfoFormat(format, arg0, arg1);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.InfoFormat(format, arg0, arg1, arg2);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Info.{0}", _log.Logger.Name));
            _log.InfoFormat(provider, format, args);
        }

        public void Warn(object message)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.Warn(message, exception);
        }

        public void WarnFormat(string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.WarnFormat(format, args);
        }

        public void WarnFormat(string format, object arg0)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.WarnFormat(format, arg0);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.WarnFormat(format, arg0, arg1);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.WarnFormat(format, arg0, arg1, arg2);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Warn.{0}", _log.Logger.Name));
            _log.WarnFormat(provider, format, args);
        }

        public void Error(object message)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.Error(message, exception);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.ErrorFormat(format, args);
        }

        public void ErrorFormat(string format, object arg0)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.ErrorFormat(format, arg0);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.ErrorFormat(format, arg0, arg1);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.ErrorFormat(format, arg0, arg1, arg2);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Error.{0}", _log.Logger.Name));
            _log.ErrorFormat(provider, format, args);
        }

        public void Fatal(object message)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Fatal.{0}", _log.Logger.Name));
            _log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Debug.{0}", _log.Logger.Name));
            _log.Fatal(message, exception);
        }

        public void FatalFormat(string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Fatal.{0}", _log.Logger.Name));
            _log.FatalFormat(format, args);
        }

        public void FatalFormat(string format, object arg0)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Fatal.{0}", _log.Logger.Name));
            _log.FatalFormat(format, arg0);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Fatal.{0}", _log.Logger.Name));
            _log.FatalFormat(format, arg0, arg1);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Fatal.{0}", _log.Logger.Name));
            _log.FatalFormat(format, arg0, arg1, arg2);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (_AnalyticsFeatureProvider != null)
                _AnalyticsFeatureProvider.TrackFeatureAndAggregate(string.Format("Lms.Client.Log.Fatal.{0}", _log.Logger.Name));
            _log.FatalFormat(provider, format, args);
        }

        public bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return _log.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return _log.IsWarnEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return _log.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return _log.IsFatalEnabled; }
        }
    }
}
