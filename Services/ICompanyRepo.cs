using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public interface ICompanyRepo
    {
        CompanyEntity GetCompany(int id);
        IEnumerable<CompanyEntity> GetCompanies();
        void AddCompnay(CompanyEntity company);
        bool Save();
        void DeleteCompany(CompanyEntity company);
    }
}
