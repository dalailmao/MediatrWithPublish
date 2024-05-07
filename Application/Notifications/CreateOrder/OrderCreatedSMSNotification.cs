using MediatR;
using MediatrWithPublish.Domain;

namespace MediatrWithPublish.Application.Notifications.CreateOrder
{
    public class OrderCreatedSMSNotification : INotificationHandler<OrderCreatedNotification>
    {
        private readonly ILogger<OrderCreatedSMSNotification> _logger;

        public OrderCreatedSMSNotification(ILogger<OrderCreatedSMSNotification> logger)
        {
            _logger = logger;
        }

        public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
        {
            // Send a confirmation SMS
            _logger.LogInformation($"Confirmation SMS sent for order {notification.Order.Id}");

            return Task.CompletedTask;
        }
    }
}
