using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Data
{
    /// <summary>
    /// Represents the base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public virtual int Id { get; set; }
    }
}
