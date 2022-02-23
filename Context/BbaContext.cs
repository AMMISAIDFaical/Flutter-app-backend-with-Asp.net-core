using BusAppBackend.Entities;
using BusAppBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Context
{
    public class BbaContext : DbContext
    {
        public BbaContext(DbContextOptions options) : base (options)
        {
        }
        public DbSet<ClientEntity> ClientEntity { get; set; }
        public DbSet<BusEntity>  BusEntity { get; set; }
        public DbSet<BusImgUrlEntity> BusImgUrlEntity { get; set; }
        public DbSet<CompanyEntity> CompanyEntity{ get; set; }
        public DbSet<ReservationEntity> ReservationEntity { get; set; }
        public DbSet<TripEntity> TripsEntity { get; set; }
        public DbSet<StopsEntity> StopsEntity { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=BBaFinalContext; Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClientEntity>().HasData(
                new ClientEntity()
                {
                    Id = 1,
                    name = "rock n roll baby",
                    email = "rnb@gmail.com",
                    age = 21,
                    password = "azerty",
                    gender = 'M',
                    phoneNumber = "07586535"
                },
                new ClientEntity()
                {
                    Id = 2,
                    name = "CURRY",
                    email = "Steph@gmail.com",
                    age = 29,
                    password = "chefCurry",
                    gender = 'M',
                    phoneNumber = "06585535"
                },
                new ClientEntity()
                {
                    Id = 3,
                    name = "yela",
                    email = "yela@gmail.com",
                    age = 40,
                    password = "MakeMeBeliver",
                    gender = 'M',
                    phoneNumber = "05196732"
                }
           );
            modelBuilder.Entity<BusEntity>().HasData(
                new BusEntity()
                {
                    id = 1,
                    marque = "chevy",
                    model = "F32 camaro",
                    year = "2022",
                    nbrSeats = 50,
                    CompanyId = 1
                },
                new BusEntity(){
                    id = 2,
                    marque = "mercedes",
                    model = "benz",
                    year = "2021",
                    nbrSeats = 60,
                    CompanyId = 1
                } ,
                new BusEntity()
                {
                    id = 3,
                    marque = "vols",
                    model = "777 vols",
                    year = "2020",
                    nbrSeats = 55,
                    CompanyId = 2
                }
            );
            modelBuilder.Entity<BusImgUrlEntity>().HasData(
                new BusImgUrlEntity()
                {
                    Id = 1,
                    Url = "url for chevy 1",
                    BusEntityId = 1 ,
                },
                new BusImgUrlEntity()
                {
                    Id = 2,
                    Url = "url for chevy 2",
                    BusEntityId = 1,
                },
                new BusImgUrlEntity()
                {
                    Id = 3,
                    Url = "url for benz",
                    BusEntityId = 2,
                }
            );
            modelBuilder.Entity<CompanyEntity>().HasData(
                new CompanyEntity()
                {
                    Id = 1,
                    Name = "bus comp 1",
                    Wilaya = "ghardaia",
                    Adress = "adr 1"
                },
                new CompanyEntity()
                {
                    Id = 2,
                    Name = "bus comp 2",
                    Wilaya = "alger",
                    Adress = "adr 2"
                }
            );
            modelBuilder.Entity<ReservationEntity>().HasData(
                new ReservationEntity()
                {
                    Id = 1,
                    Status = "valide",
                    ClientId = 1,
                    TripId = 1 
                },
                new ReservationEntity()
                {
                    Id = 2,
                    Status = "pending",
                    ClientId = 2,
                    TripId = 2
                }
            );
            modelBuilder.Entity<TripEntity>().HasData(
                new TripEntity()
                {
                    Id = 1,
                    Depart = "ghardaia",
                    Arrivel = "alger",
                    DateDepart = "2022-12-06/6:00 am",
                    NbrPlaces = 3,
                    Commentaire = "its cool bus !",
                    Note = 10,
                    BusId = 1,
                    StopsId = 2
                },
                new TripEntity()
                {
                    Id = 2,
                    Depart = "setif",
                    Arrivel = "ghardaia",
                    DateDepart = "2022-12-06/14:00 pm",
                    NbrPlaces = 1,
                    Commentaire = "its not bad trip  !",
                    Note = 8,
                    BusId = 2,
                    StopsId = 1
                }
            ) ;
            modelBuilder.Entity<StopsEntity>().HasData(
                    new StopsEntity()
                    {
                        Id = 1,
                        Stops = "laghwat,djelfa,msilla,bordj",
                    },
                    new StopsEntity()
                    {
                        Id = 2,
                        Stops = "laghwat,djelfa,bosaada,media"
                    },  
                    new StopsEntity()
                    {
                        Id = 3,
                        Stops = "wilaya A,wilaya B,wilaya C "
                    } 
                );
        }
        
    }
}
