using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    /// <summary>
    /// Mapper profile registrar interface
    /// </summary>
    public interface IOrderedMapperProfile
    {
        /// <summary>
        /// Gets order of this configuration implementation
        /// </summary>
        int Order { get; }
    }
}
