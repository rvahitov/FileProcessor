using System;
using System.Collections.Generic;
using Serilog.Core;
using Serilog.Core.Enrichers;

namespace Logging
{
    internal class SerilogLoggerContext : ILogContext
    {
        private readonly List<ILogEventEnricher> _enrichers = new List<ILogEventEnricher>();
        public ILogEventEnricher[] Enrichers => _enrichers.ToArray();

        #region Implementation of ILogContext

        public ILogContext AddProperty(string name, object value, bool destructure = false)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            _enrichers.Add(new PropertyEnricher(name, value, destructure));
            return this;
        }

        #endregion
    }
}