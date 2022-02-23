using AutoMapper;
using BusAppBackend.Entities;
using BusAppBackend.Models;
using BusAppBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Controllers
{
    [Route("api/busImg")]
    [ApiController]
    public class BusImgController : ControllerBase
    {
        private readonly IBusRepo _busRepo;
        private readonly IMapper _mapper;
        public BusImgController (IBusRepo busRepo, IMapper mapper)
        {
            _mapper = mapper;
            _busRepo = busRepo ?? throw new ArgumentNullException(nameof(busRepo));
        }

        [HttpPost]
        [ActionName(nameof(AddBusImg))]
        public IActionResult AddBusImg([FromBody] BusImgUrlModel busImg)
        {
            var AddedBusImg = _mapper.Map<BusImgUrlEntity>(busImg);
            _busRepo.AddBusImg(AddedBusImg);
            _busRepo.Save();
            return CreatedAtAction("Getbuss", busImg);
        }
        [HttpGet("{busId}")]
        public IActionResult GetBusImgByBusId(int busId)
        {
            var busImg = _busRepo.GetImgUrlByBusId(busId);
            return Ok(_mapper.Map<BusImgUrlModel>(busImg));
        }

    }
}
