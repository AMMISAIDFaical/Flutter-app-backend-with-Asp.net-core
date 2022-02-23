using AutoMapper;
using BusAppBackend.Entities;
using BusAppBackend.Models;
using BusAppBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BusAppBackend.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;
        public CompanyController(ICompanyRepo companyRepo, IMapper mapper)
        {
            _companyRepo = companyRepo;
            _mapper = mapper;
        }
        // GET: api/<CompanyController>
        [HttpGet]
        public IActionResult GetCompanies()
        {
            var companiesEntities = _companyRepo.GetCompanies();
            return Ok(_mapper.Map<IEnumerable<CompanyModel>>(companiesEntities));
        }

        [HttpGet("{id}")]
        public IActionResult GetCompany (int id)
        {
            var companyEntity = _companyRepo.GetCompany(id);
            return Ok(_mapper.Map<CompanyModel>(companyEntity));
        }
        // POST api/<CompanyController>
        [HttpPost]
        public IActionResult AddCompany([FromBody] CompanyModel company)
        {
            CompanyEntity companyTobeAdded = _mapper.Map<CompanyEntity>(company);
           _companyRepo.AddCompnay(companyTobeAdded);
           _companyRepo.Save();
            return CreatedAtAction("GetComp", company);
        }
         
        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var companyEntity = _companyRepo.GetCompany(id);
            _companyRepo.DeleteCompany(companyEntity);
        }
    }
}
