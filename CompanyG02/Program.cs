using CompanyG02.Data;

namespace CompanyG02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CompanyDBContext companyDBContext = new CompanyDBContext())
            {

                #region Add
                //Employee emp01 = new Employee() { Name = "Nada", Age = 26, Salary = 9_000, Email = "Nada@gmail.com" };
                //Employee emp02 = new Employee() {Id=1,  Name = "Rana", Age = 26, Salary = 8_000, Email = "Rana@gmail.com" };

                //Console.WriteLine(companyDBContext.Entry(emp01).State);//Detached
                //Console.WriteLine(companyDBContext.Entry(emp02).State);//Detached

                //companyDBContext.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.TrackAll;//Default Behaviour

                //Employee emp04 = new Employee() { Id = 3, Name = "Omar", Age = 26, Salary = 8_000, Email = "Rana@gmail.com" };

                //companyDBContext.Set<Employee>().Add(emp04); // .toTable instead of dbSet
                // companyDBContext.Employees.Add(emp01); //as Local Sequence 
                // companyDBContext.Add(emp02);
                //companyDBContext.Entry(emp01).State=EntityState.Added;

                #endregion
                #region Get And Update
                //var emp = (from e in companyDBContext.Employees
                //           where e.Id == 3
                //           select e).FirstOrDefault();


                //if(emp is not null)
                //{
                //    Console.WriteLine(companyDBContext.Entry(emp).State);
                //    Console.WriteLine(emp.Name);
                //    Console.WriteLine(emp.Email);
                //    emp.Salary = 10_000;
                //    Console.WriteLine(companyDBContext.Entry(emp).State);

                //}
                #endregion

                #region Get And Remove

                var emp = (from e in companyDBContext.Employees
                           where e.Id == 3
                           select e).FirstOrDefault();


                if (emp is not null)
                {
                    Console.WriteLine(companyDBContext.Entry(emp).State);
                    Console.WriteLine(emp.Name);

                    //companyDBContext.Set<Employee>().Remove(emp); // .toTable instead of dbSet
                    /*companyDBContext.Employees.Remove(emp); *///as Local Sequence 
                    companyDBContext.Remove(emp);
                    //companyDBContext.Entry(emp).State = EntityState.Deleted;
                    //
                    Console.WriteLine(companyDBContext.Entry(emp).State);

                }
                #endregion
                companyDBContext.SaveChanges();
            }
        }
    }
}
