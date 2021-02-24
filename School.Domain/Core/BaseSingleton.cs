using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    /// <summary>
    /// Provides access to all "singletons" stored by <see cref="Singleton{T}"/>.
    /// </summary>
    public class BaseSingleton
    {
        static BaseSingleton()
        {
            AllSingletons = new Dictionary<Type, object>();
        }

        /// <summary>
        /// Dictionary of type to singleton instances.
        /// </summary>
        public static IDictionary<Type, object> AllSingletons { get; }
    }
}
