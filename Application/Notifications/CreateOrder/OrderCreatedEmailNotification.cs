using MediatR;
using MediatrWithPublish.Domain;

namespace MediatrWithPublish.Application.Notifications.CreateOrder
{
    public class OrderCreatedEmailNotification : INotificationHandler<OrderCreatedNotification>
    {
        private readonly ILogger<OrderCreatedEmailNotification> _logger;

        public OrderCreatedEmailNotification(ILogger<OrderCreatedEmailNotification> logger)
        {
            _logger = logger;
        }

        public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
        {
            // Send a confirmation email
            _logger.LogInformation($"Confirmation email sent for order {notification.Order.Id}");

            return Task.CompletedTask;
        }
    }
}
