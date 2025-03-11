using CompanyG02.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CompanyG02.Data.DataSeed
{
    static class CompanyDBContextSeed
    {

        public static void Seed(CompanyDBContext companyDBContext)
        {

            var departmentsData = File.ReadAllText("C:\\Users\\ahmed\\OneDrive\\Desktop\\efcore demo\\CompanyG02Solution\\CompanyG02\\Data\\DataSeed\\departments.json");
            var departments = JsonSerializer.Deserialize<List<Department>>(departmentsData);

            if (departments?.Count > 0)
            {
                foreach (var department in departments)
                {
                    companyDBContext.Departments.Add(department);
                } 
                companyDBContext.SaveChanges();
            }
        }

    }
}
