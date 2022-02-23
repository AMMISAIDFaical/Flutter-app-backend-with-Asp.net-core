using BusAppBackend.Context;
using BusAppBackend.Entities;
using BusAppBackend.Models;
using Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public class ClientRepo : IClientRepo
    {
        private readonly BbaContext _context;
        
        public ClientRepo(BbaContext context)
        {
            _context = context;
        }

        public void AddClient(ClientEntity client)
        {
            _context.ClientEntity.Add(client);
        }

        public void Delete(ClientEntity client)
        {
            _context.ClientEntity.Remove(client);
        }

        public ClientEntity GetClient(int id)
        {
            return _context.ClientEntity.Where(c => c.Id == id).FirstOrDefault();
        }

        public ClientEntity GetClientByEmail(string email)
        {
            return _context.ClientEntity.Where(c => c.email == email).FirstOrDefault();
        }

        public IEnumerable<ClientEntity> GetClients()
        {
            return _context.ClientEntity.ToList();
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        ClientEntity IClientRepo.GetClientByPhoneNumber(string phoneNumber)
        {
            return _context.ClientEntity.Where(c => c.phoneNumber == phoneNumber).FirstOrDefault();
        }
    }
}
