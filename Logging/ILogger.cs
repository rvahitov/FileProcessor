using System;
using JetBrains.Annotations;

namespace Logging
{
    public interface ILogger
    {
        [NotNull]
        IDisposable ForContext([NotNull] Action<ILogContext> contextSetup);

        void Debug([NotNull] string messageTemplate, params object[] templateValues);
        void Information([NotNull] string messageTemplate, params object[] templateValues);
        void Warning([NotNull] string messageTemplate, params object[] templateValues);
        void Error([NotNull] string messageTemplate, params object[] templateValues);
        void Error([NotNull] Exception exception, [NotNull] string messageTemplate, params object[] templateValues);
    }
}