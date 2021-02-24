using School.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Events
{
    /// <summary>
    /// A container for entities that are updated.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityUpdatedEvent<T> where T : BaseEntity
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="entity">Entity</param>
        public EntityUpdatedEvent(T entity)
        {
            Entity = entity;
        }

        /// <summary>
        /// Entity
        /// </summary>
        public T Entity { get; }
    }
}
