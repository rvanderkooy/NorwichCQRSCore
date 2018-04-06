using NorwichCQRS.Infrastructure.Providers;
using System;

namespace NorwichCQRS.Core.Providers
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime CurrentDateTime
        {
            get { return DateTime.UtcNow; }
        }
    }
}
