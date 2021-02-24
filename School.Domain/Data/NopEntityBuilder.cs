using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator.Builders.Create.Table;

namespace School.Domain.Data
{
    /// <summary>
    /// Represents base entity builder
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <remarks>
    /// "Entity type <see cref="TEntity"/>" is needed to determine the right entity builder for a specific entity type
    /// </remarks>
    public abstract class NopEntityBuilder<TEntity> : IEntityBuilder where TEntity : BaseEntity
    {
        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public abstract void MapEntity(CreateTableExpressionBuilder table);
    }
}
