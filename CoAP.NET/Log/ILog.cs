using System;

namespace CoAP.Common.Logging
{
    //TODO:Added to remove dependency on Common.Logging nuget, needs to be fixed
    public interface ILog
    {
        bool IsDebugEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsFatalEnabled { get; }
        bool IsErrorEnabled { get; }

        void Debug(Object message);
        void Debug(Object message, Exception exception);
        void DebugFormat(String format, params Object[] args);
        void DebugFormat(IFormatProvider provider, String format, params Object[] args);
        void Error(Object message, Exception exception);
        void Error(Object message);
        void ErrorFormat(String format, Object arg0, Object arg1, Object arg2);
        void ErrorFormat(IFormatProvider provider, String format, params Object[] args);
        void Fatal(Object message);
        void FatalFormat(IFormatProvider provider, String format, params Object[] args);
        void InfoFormat(string format, object[] args);
        void InfoFormat(String format, Object arg0);
        void InfoFormat(String format, Object arg0, Object arg1);
        void InfoFormat(IFormatProvider provider, String format, params Object[] args);
        void InfoFormat(String format, Object arg0, Object arg1, Object arg2);
        void WarnFormat(IFormatProvider provider, String format, params Object[] args);
        void WarnFormat(String format, Object arg0, Object arg1, Object arg2);
        void WarnFormat(String format, Object arg0, Object arg1);
        void WarnFormat(String format, Object arg0);
        void WarnFormat(String format, params Object[] args);
        void Warn(Object message, Exception exception);
        void Warn(Object message);
        void Info(Object message);
        void FatalFormat(String format, Object arg0, Object arg1, Object arg2);
        void FatalFormat(String format, Object arg0, Object arg1);
        void FatalFormat(String format, Object arg0);
        void Info(Object message, Exception exception);
        void ErrorFormat(String format, Object arg0, Object arg1);
        void ErrorFormat(String format, Object arg0);
        void ErrorFormat(String format, params Object[] args);
        void Fatal(Object message, Exception exception);
    }
    public class ConsoleLogger : ILog
    {
        public bool IsDebugEnabled => throw new NotImplementedException();

        public bool IsWarnEnabled => throw new NotImplementedException();

        public bool IsInfoEnabled => throw new NotImplementedException();

        public bool IsFatalEnabled => throw new NotImplementedException();

        public bool IsErrorEnabled => throw new NotImplementedException();

        public void Debug(object message)
        {
            throw new NotImplementedException();
        }

        public void Debug(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(object message)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void Info(object message)
        {
            throw new NotImplementedException();
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
