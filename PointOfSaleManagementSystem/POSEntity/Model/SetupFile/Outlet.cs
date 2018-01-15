using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class Outlet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }

        public int organizationID { get; set; }
        public virtual Organization organization { get; set; }

        public virtual ICollection<Employee> EmployeeList { get; set; }
    }
}
