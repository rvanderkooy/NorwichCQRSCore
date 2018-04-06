using System;

namespace NorwichCQRS.Infrastructure.CommandMessaging
{
    public interface ICommand
    {
        DateTime DateTime { get; }
    }
}
