using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    //Code First Approach

    //01 - Migration Command - "Add-Migration Init"
    //02 - After Migration - Update-Database
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }

        //Employee Table
         DbSet<Employees> Employees
        {
            get;
            set;
        }



    }
}
