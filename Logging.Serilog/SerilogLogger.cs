using System;
using Serilog.Context;

namespace Logging
{
    internal class SerilogLogger : ILogger
    {
        private readonly Serilog.ILogger _logger;

        public SerilogLogger(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        #region Implementation of ILogger

        public IDisposable ForContext(Action<ILogContext> contextSetup)
        {
            if (contextSetup == null) throw new ArgumentNullException(nameof(contextSetup));
            var context = new SerilogLoggerContext();
            contextSetup(context);
            return LogContext.Push(context.Enrichers);
        }

        public void Debug(string messageTemplate, params object[] templateValues)
        {
            if (messageTemplate == null) throw new ArgumentNullException(nameof(messageTemplate));
            _logger.Debug(messageTemplate, templateValues);
        }

        public void Information(string messageTemplate, params object[] templateValues)
        {
            if (messageTemplate == null) throw new ArgumentNullException(nameof(messageTemplate));
            _logger.Information(messageTemplate, templateValues);
        }

        public void Warning(string messageTemplate, params object[] templateValues)
        {
            if (messageTemplate == null) throw new ArgumentNullException(nameof(messageTemplate));
            _logger.Warning(messageTemplate, templateValues);
        }

        public void Error(string messageTemplate, params object[] templateValues)
        {
            if (messageTemplate == null) throw new ArgumentNullException(nameof(messageTemplate));
            _logger.Error(messageTemplate, templateValues);
        }

        public void Error(Exception exception, string messageTemplate, params object[] templateValues)
        {
            if (exception == null) throw new ArgumentNullException(nameof(exception));
            if (messageTemplate == null) throw new ArgumentNullException(nameof(messageTemplate));
            _logger.Error(exception, messageTemplate, templateValues);
        }

        #endregion
    }
}