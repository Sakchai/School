using FluentMigrator.Builders.Create.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Data
{
    /// <summary>
    /// Represents database entity builder
    /// </summary>
    public interface IEntityBuilder
    {
        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        void MapEntity(CreateTableExpressionBuilder table);
    }
}
