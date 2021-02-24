using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    /// <summary>
    /// Represents a soft-deleted (without actually deleting from storage) entity
    /// </summary>
    public partial interface ISoftDeletedEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        bool Deleted { get; set; }
    }
}
