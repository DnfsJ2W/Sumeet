using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirstcore.Models
{
    public partial class Tbldepartment
    {
        public Tbldepartment()
        {
            Tblemployees = new HashSet<Tblemployee>();
        }

        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Tblemployee> Tblemployees { get; set; }
    }
}
