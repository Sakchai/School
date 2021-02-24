using School.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    /// <summary>
    /// Represents default values related to caching entities
    /// </summary>
    public static partial class NopEntityCacheDefaults<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Gets an entity type name used in cache keys
        /// </summary>
        public static string EntityTypeName => typeof(TEntity).Name.ToLowerInvariant();

        /// <summary>
        /// Gets a key for caching entity by identifier
        /// </summary>
        /// <remarks>
        /// {0} : entity id
        /// </remarks>
        public static CacheKey ByIdCacheKey => new CacheKey($"Nop.{EntityTypeName}.byid.{{0}}", ByIdPrefix, Prefix);

        /// <summary>
        /// Gets a key for caching entities by identifiers
        /// </summary>
        /// <remarks>
        /// {0} : entity ids
        /// </remarks>
        public static CacheKey ByIdsCacheKey => new CacheKey($"Nop.{EntityTypeName}.byids.{{0}}", ByIdsPrefix, Prefix);

        /// <summary>
        /// Gets a key for caching all entities
        /// </summary>
        public static CacheKey AllCacheKey => new CacheKey($"Nop.{EntityTypeName}.all.", AllPrefix, Prefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string Prefix => $"Nop.{EntityTypeName}.";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ByIdPrefix => $"Nop.{EntityTypeName}.byid.";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ByIdsPrefix => $"Nop.{EntityTypeName}.byids.";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string AllPrefix => $"Nop.{EntityTypeName}.all.";
    }
}
