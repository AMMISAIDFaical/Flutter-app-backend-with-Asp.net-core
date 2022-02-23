using AutoMapper;
using BusAppBackend.Entities;
using BusAppBackend.Models;
using Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepo _clientRepo;
        private readonly IMapper _mapper;
        public ClientController(IClientRepo clientRepo,IMapper mapper)
        {
            _clientRepo = clientRepo  ?? throw new ArgumentNullException(nameof(clientRepo));
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetClients()
         {
            var clientsEntities = _clientRepo.GetClients();
            return Ok(_mapper.Map<IEnumerable<ClientModel>>(clientsEntities));
        }

       [HttpGet("GetById/{id}")]
        public IActionResult GetClient(int id)
        {
            var clientsEntities = _clientRepo.GetClient(id);
            return Ok(_mapper.Map<ClientModel>(clientsEntities));
        }
        [HttpPost]
        public IActionResult AddClient([FromBody] ClientModel client)
        {
            _clientRepo.AddClient(_mapper.Map<ClientEntity>(client));
            _clientRepo.Save();
            return CreatedAtAction("GetClients", client);
        }
         [HttpGet("GetByEmail/{email}")]
         public IActionResult GetClientByEmail (string email) 
         {
             var clientEntity = _clientRepo.GetClientByEmail(email);
             return Ok(_mapper.Map<ClientModel>(clientEntity));
         }
        [HttpGet("GetByPh/{phoneNumber}")]
        public IActionResult GetClientByPhone(string phoneNumber)
        {
            var clientEntity = _clientRepo.GetClientByPhoneNumber(phoneNumber);
            return Ok(_mapper.Map<ClientModel>(clientEntity));
        }
    }
}
