using JetBrains.Annotations;

namespace Logging
{
    public interface ILogContext
    {
        [NotNull]
        ILogContext AddProperty([NotNull] string name, [NotNull] object value, bool destructure = false);
    }
}