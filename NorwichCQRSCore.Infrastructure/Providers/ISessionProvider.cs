using System;

namespace NorwichCQRS.Infrastructure.Providers
{
    public interface ISessionProvider
    {
        Guid GetUserID();
    }
}
