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
    public class EnrollmentBuilder : NopEntityBuilder<Enrollment>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Enrollment.CourseId)).AsInt32().ForeignKey<Course>()
                .WithColumn(nameof(Enrollment.Grade)).AsInt32().NotNullable()
                .WithColumn(nameof(Enrollment.StudentId)).AsInt32().ForeignKey<Student>();
        }

        #endregion
    }
}
