using FluentMigrator.Builders.Create.Table;
using School.Domain.Data;
using School.Domain.Model;

namespace School.Domain.Mapping
{
    /// <summary>
    /// Represents a log entity builder
    /// </summary>
    public partial class LogBuilder : NopEntityBuilder<Log>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Log.ShortMessage)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(Log.IpAddress)).AsString(200).Nullable()
                .WithColumn(nameof(Log.StudentId)).AsInt32().Nullable().ForeignKey<Student>();
        }

        #endregion
    }
}