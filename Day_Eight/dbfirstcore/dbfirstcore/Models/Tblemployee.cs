using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirstcore.Models
{
    public partial class Tblemployee
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public decimal? Esalary { get; set; }
        public int DeptId { get; set; }

        public virtual Tbldepartment Dept { get; set; }
    }
}
