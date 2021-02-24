using School.Domain.Core;
using School.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Domain.Model
{
    public partial class Student : BaseEntity, ISoftDeletedEntity
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool Deleted { get; set; }
    }
}
