using FluentMigrator.Builders.Create.Table;
using School.Domain.Data;
using School.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Mapping
{
    public class CourseBuilder : NopEntityBuilder<Course>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Course.Credits)).AsInt32().NotNullable()
                .WithColumn(nameof(Course.Title)).AsString().Nullable();
        }

        #endregion
    }
}
