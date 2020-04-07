using System;

namespace CoAP.Common.Logging
{
    internal class LogManager
    {
        internal static ILog GetLogger(Type type)
        {
            return new DConsoleLogger();
        }

        internal static ILog GetLogger(string name)
        {
            return new DConsoleLogger();
        }
    }
    public class DConsoleLogger : ILog, IDisposable
    {
        public bool IsDebugEnabled => true;

        public bool IsWarnEnabled => true;

        public bool IsInfoEnabled => true;

        public bool IsFatalEnabled => true;

        public bool IsErrorEnabled => true;

        public IDisposable BeginScope<TState>(TState state)
        {
            return this;
        }

        public void Debug(object message)
        {
            Console.WriteLine($"DLOGGER DEBUG: {message}");
        }

        public void Debug(object message, Exception exception)
        {
            Console.WriteLine($"DLOGGER DEBUG EXCEPTION: {message} {exception}");
        }

        public void DebugFormat(string format, params object[] args)
        {
            Console.WriteLine($"DLOGGER DEBUG FORMAT: {string.Format(format, args)}");
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            Console.WriteLine($"DLOGGER DEBUG FORMAT: {string.Format(format, args)}");
        }

        public void Dispose()
        {
        }

        public void Error(object message, Exception exception)
        {
            Console.WriteLine($"DLOGGER DEBUG ERROR: {message} {exception}");

        }

        public void Error(object message)
        {
            Console.WriteLine($"DLOGGER DEBUG ERROR: {message}");

        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine($"DLOGGER ERROR FORMAT: {string.Format(format, arg1, arg2)}");

        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            Console.WriteLine($"DLOGGER ERROR FORMAT: {string.Format(format, args)}");
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            Console.WriteLine($"DLOGGER ERROR FORMAT: {string.Format(format, arg0, arg1)}");
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

        //public bool IsEnabled(LogLevel logLevel)
        //{
        //    return true;
        //}

        //public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        //{
        //    Console.WriteLine("Log");
        //}
    }
}
