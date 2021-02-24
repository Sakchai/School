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
    public class StudentBuilder : NopEntityBuilder<Student>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Student.Deleted)).AsInt32().NotNullable()
                .WithColumn(nameof(Student.EnrollmentDate)).AsDateTime2().Nullable()
                .WithColumn(nameof(Student.FirstMidName)).AsString().NotNullable()
                .WithColumn(nameof(Student.LastName)).AsString().NotNullable();
        }

        #endregion
    }
}
