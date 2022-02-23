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
    [Route("api/trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ITripRepo _tripRepo;
        private readonly IMapper _mapper;
        public TripController(ITripRepo  tripRepo, IMapper mapper)
        {
            _tripRepo  = tripRepo;
            _mapper = mapper;
        }
        // GET: api/<TripController>
        [HttpGet]
        public  IActionResult GetTrips()
        {
            var tripsEntities = _tripRepo.GetTrips();
            return Ok(_mapper.Map<IEnumerable<TripModel>>(tripsEntities));
        }

        // getting trips by id
        [HttpGet("GetTripById/{id}")]
        public IActionResult GetTripsById(int id)
        {
            var tripEntity = _tripRepo.GetTripById(id);
            return Ok(_mapper.Map<TripModel>(tripEntity));
        }
        // getting trips by busId
        [HttpGet("GetTripByBusId/{busId}")]
        public IActionResult GetTripsByBusId(int BusId)
        {
            var tripEntity = _tripRepo.GetTripByBus(BusId);
            return Ok(_mapper.Map<TripModel>(tripEntity));
        }
        [HttpGet("GetTripByCord/{depart}/{arrival}")]
        public IActionResult GetTripByDepArrDate(string depart,string arrival)
        {
            var tripEntity = _tripRepo.GetTripByCord(depart, arrival);
            return Ok(_mapper.Map<TripModel>(tripEntity));
        }
        //adding trip to tripsEntity table
        [HttpPost]
        public IActionResult Post([FromBody] TripModel trip)
        {
            _tripRepo.AddTrip(_mapper.Map<TripEntity>(trip));
            _tripRepo.Save();
            return CreatedAtAction("GetTrip", trip);
        }

        // PUT api/<TripController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<TripController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tripRepo.DeleteTrip(_tripRepo.GetTripById(id));
        }
        [HttpGet("GetTripStops/{stopId}")]
        public IActionResult GetTripStops(int stopId)
        {
            var stops = _tripRepo.GetStopsById(stopId);
            return Ok(_mapper.Map<StopModel>(stops));
        }

    }
}
