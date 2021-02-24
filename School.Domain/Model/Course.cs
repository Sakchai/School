using School.Domain.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Domain.Model
{
    public partial class Course : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
