﻿using System;

namespace NorwichCQRS.Infrastructure.ServicePresenters
{
    public interface IServicePresenter
    {
        event System.EventHandler<StatusUpdatedArgs> StatusUpdated;
    }

    public class StatusUpdatedArgs : EventArgs
    {
        public string Status { get; internal set; }

        public StatusUpdatedArgs(string status)
        {
            this.Status = status;
        }
    }
}
