using School.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Domain.Model
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public partial class Enrollment : BaseEntity
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

    }
}
