using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirstcore.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int? Marks { get; set; }
    }
}
