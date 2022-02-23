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
{   [ApiController]
    [Route("api/bus")]
    public class BusController : ControllerBase
    {
        private readonly IBusRepo _busRepo;
        private readonly IMapper _mapper;
        public BusController(IBusRepo busRepo, IMapper mapper)
        {
            _mapper = mapper;
            _busRepo = busRepo ?? throw new ArgumentNullException(nameof(busRepo));
        }
        [HttpGet]
        public IActionResult GetBuses() 
        {
            var BusesEntities = _busRepo.Getbuses();
            return Ok(_mapper.Map<IEnumerable<BusModel>>(BusesEntities));
        }
        [HttpPost]
        [ActionName(nameof(AddBus))]
        public IActionResult AddBus([FromBody] BusModel bus)
        {
            var AddedBus = _mapper.Map<BusEntity>(bus);
            _busRepo.AddBus(AddedBus);
            _busRepo.Save();
            return CreatedAtAction("Getbuss", AddedBus);
        }
        

    }
}
