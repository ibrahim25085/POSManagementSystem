using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class EmployeeDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<Employee> GetAll()
        {
            return this.context.Employees.ToList();
        }
        public Employee Get(int ID)
        {
            return this.context.Employees.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(Employee employee)
        {
            Employee Emp = this.context.Employees.FirstOrDefault(x => x.ID == employee.ID);
            Emp.Name = employee.Name;
            Emp.Image = employee.Image;
            Emp.Email = employee.Email;
            Emp.ContactNo = employee.ContactNo;
            Emp.EmargencyContactNo = employee.EmargencyContactNo;
            Emp.FatherName = employee.FatherName;
            Emp.MotherName = employee.MotherName;
            Emp.NID = employee.NID;
            Emp.Outlet = employee.Outlet;
            Emp.PresentAddress = employee.PresentAddress;
            Emp.PermanentAddress = employee.PermanentAddress;
            Emp.outletID = employee.outletID;
           

            return this.context.SaveChanges();

        }

        public int Delete(int ID)
        {
            Employee Emp = this.context.Employees.FirstOrDefault(x => x.ID == ID);
            this.context.Employees.Remove(Emp);

            return this.context.SaveChanges();
        }

        public int Insert(Employee employee)
        {
            this.context.Employees.Add(employee);
            return this.context.SaveChanges();
        }
    }
}
