using BusAppBackend.Context;
using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public class BusRepo : IBusRepo
    {
        private readonly BbaContext _context;
        public BusRepo(BbaContext context)
        {
            _context = context;
        }
        public void AddBus(BusEntity bus)
        {
            _context.BusEntity.Add(bus);
        }

        public void Delete(BusEntity bus)
        {
            _context.BusEntity.Remove(bus);
        }

        public BusEntity GetBus(int id)
        {

            return _context.BusEntity.Where(b => b.id == id).FirstOrDefault();
        }

        public BusEntity GetBusByModel(string model)
        {
            return _context.BusEntity.Where(b => b.model == model).FirstOrDefault();
        }

        public BusEntity GetBusByNbrSeats(int nbrSeats)
        {
            return _context.BusEntity.Where(b => b.nbrSeats == nbrSeats).FirstOrDefault();
        }

        public IEnumerable<BusEntity> Getbuses()
        {
            return _context.BusEntity.ToList();
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0; 
        }

        public BusImgUrlEntity GetImgUrlByBusId(int BusId)
        {
            return _context.BusImgUrlEntity.Where(img => img.BusEntityId== BusId).FirstOrDefault();
        }

        public void AddBusImg(BusImgUrlEntity busImg)
        {
            _context.BusImgUrlEntity.Add(busImg);
        }
    }
}
