using MediatR;

namespace MediatrWithPublish.Domain
{
    public class OrderCreatedNotification : INotification
    {
        public required Order Order { get; set; }
    }
}
