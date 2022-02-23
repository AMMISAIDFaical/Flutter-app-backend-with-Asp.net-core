using BusAppBackend.Context;
using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly BbaContext _context;
        
        public CompanyRepo(BbaContext context)
        {
            _context = context;
        }

        public void AddCompnay(CompanyEntity company)
        {
            _context.CompanyEntity.Add(company);
        }

        public void DeleteCompany(CompanyEntity company)
        {
            _context.CompanyEntity.Remove(company);
        }

        public IEnumerable<CompanyEntity> GetCompanies()
        {
            return _context.CompanyEntity.ToList();
        }

        public CompanyEntity GetCompany(int id)
        {
            return _context.CompanyEntity.Where(c => c.Id == id).FirstOrDefault();
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
