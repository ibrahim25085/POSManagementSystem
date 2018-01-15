using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class EmployeeService
    {
        private EmployeeDataAccess data = new EmployeeDataAccess();

        public IEnumerable<Employee> GetAll()
        {
            return this.data.GetAll();
        }
        public Employee Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(Employee emp)
        {
            return this.data.Update(emp);
        }
        public int Insert(Employee emp)
        {
            return this.data.Insert(emp);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
