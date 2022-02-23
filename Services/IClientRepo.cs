using BusAppBackend.Entities;
using BusAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Services
{
    public interface IClientRepo 
    {
        IEnumerable<ClientEntity> GetClients();

        ClientEntity GetClient(int  id);
        
        ClientEntity GetClientByEmail(string  email);

        ClientEntity GetClientByPhoneNumber(string phoneNumber);

        void AddClient(ClientEntity client);

        bool Save ();

        void Delete(ClientEntity client);

    }
}
