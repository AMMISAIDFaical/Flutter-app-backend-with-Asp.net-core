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
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {

        private readonly IReservationRepo _reservationRepo;
        private readonly IMapper _mapper;
        public ReservationController(IReservationRepo reservationRepo, IMapper mapper)
        {
            _reservationRepo = reservationRepo;
            _mapper = mapper;
        }

        [HttpGet] //getting all reservations 
        public IActionResult GetReservations()
        {
            var reservEntities = _reservationRepo.GetReservations(); 
            return Ok(_mapper.Map<IEnumerable<ReservationModel>>(reservEntities));
        }

        [HttpGet("GetResrvById/{id}")]
        public IActionResult GetReservationById(int id)
        {
            var reservationEntity = _reservationRepo.GetReservationById(id);
            return Ok(_mapper.Map<ReservationModel>(reservationEntity));
        }

        [HttpGet("GetResrvByClientId/{ClientId}")]
        public IActionResult GetReservationByClientId(int ClientId)
        {
            var reservationEntity = _reservationRepo.GetReservationByClientId(ClientId);
            return Ok(_mapper.Map<ReservationModel>(reservationEntity));
        }

        [HttpGet("GetReservByTripId/{TripId}")]
        public IActionResult GetReservationByTripId(int TripId)
        {
            var reservationEntity = _reservationRepo.GetReservationByTripId(TripId);
            return Ok(_mapper.Map<ReservationModel>(reservationEntity));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ReservationModel reservation)
        {
            _reservationRepo.AddReservation(_mapper.Map<ReservationEntity>(reservation));
            _reservationRepo.Save();
            return CreatedAtAction("addedReservation", reservation);
        }

        //status modification
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ReservationModel reservationForUpdate)
        {
            var reservationToBeChanged = _reservationRepo.GetReservationById(reservationForUpdate.Id);
            reservationToBeChanged.Status = reservationForUpdate.Status;
            _reservationRepo.Save();    
            return NoContent();
        }

        // deleting reservation
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _reservationRepo.DeleteReservation(_reservationRepo.GetReservationById(id));
            return NoContent();
        }
    }
}
