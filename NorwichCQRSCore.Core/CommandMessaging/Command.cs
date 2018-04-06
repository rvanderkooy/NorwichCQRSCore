﻿using NorwichCQRS.Infrastructure.CommandMessaging;
using NorwichCQRS.Infrastructure.Providers;
using System;

namespace NorwichCQRS.Core.CommandMessaging
{
    public class Command : ICommand
    {
        private IDateTimeProvider _dateTimeProvider;

        private Nullable<DateTime> _dateTime;

        public DateTime DateTime
        {
            get { return _dateTime ?? _dateTimeProvider.CurrentDateTime; }
            set
            {
                _dateTime = value;
            }
        }

        protected Command(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }
    }
}
