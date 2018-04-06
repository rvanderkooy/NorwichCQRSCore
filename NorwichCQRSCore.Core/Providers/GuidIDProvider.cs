using NorwichCQRS.Infrastructure.Providers;
using System;

namespace NorwichCQRS.Core.Providers
{
    public class GuidIDProvider : IIdProvider
    {
        public string GetNewID()
        {
            return Convert.ToString(Guid.NewGuid());
        }
    }
}
