using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Events
{
    /// <summary>
    /// Represents an event publisher
    /// </summary>
    public partial interface IEventPublisher
    {
        /// <summary>
        /// Publish event to consumers
        /// </summary>
        /// <typeparam name="TEvent">Type of event</typeparam>
        /// <param name="event">Event object</param>
        Task PublishAsync<TEvent>(TEvent @event);
    }
}
