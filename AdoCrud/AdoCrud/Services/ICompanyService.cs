using AdoCrud.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCrud.Services
{
    interface ICompanyService
    {
        List<tblemployee> GetEmployees();
        tblemployee GetEmployeeById(int id);
        void AddEmployee(tblemployee obj);
        void UpdateEmployee(tblemployee obj);
        void DeleteEmployee(int id);
    }
}
