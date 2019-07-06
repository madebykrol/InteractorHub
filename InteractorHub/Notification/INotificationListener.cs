﻿using System.Threading;
using System.Threading.Tasks;

namespace InteractorHub.Notification
{
    public interface INotificationListener<in TNotification> where TNotification : INotification
    {
        Task Handle(TNotification notification, CancellationToken cancellationToken) ;
    }
}