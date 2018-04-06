using System;

namespace NorwichCQRS.Infrastructure.Providers
{
    public interface IDateTimeProvider
    {
        DateTime CurrentDateTime { get; }
    }
}
