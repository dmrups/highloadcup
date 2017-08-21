using System;
using System.Linq;
using System.Collections.Generic;
using dotnetapp.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Code
{
    public class Repository : IRepository
    {
        Model model;
        SqliteConnection connection;
        DbContextOptions<Model> options;

        public Repository()
        {
            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            options = new DbContextOptionsBuilder<Model>()
                .UseSqlite(connection)
                .Options;

            model = new Model(options);
            model.Database.EnsureCreated();
        }

        // Add

        public void AddUser(User user)
        {
            model.Users.Add(user);
        }

        public void AddVisit(Visit visit)
        {
            //Visits.Add(visit.Id, visit);
        }

        public void AddLocation(Location location)
        {
            //Locations.Add(location.Id, location);
        }

        // Update

        public void UpdateUser(User user)
        {
            //Users[user.Id] = user;
        }

        public void UpdateVisit(Visit visit)
        {
            //Visits[visit.Id] = visit;
        }

        public void UpdateLocation(Location location)
        {
            //Locations[location.Id] = location;
        }

        // Get

        public User GetUser(int id)
        {
            return model.Users.Find(id);
            //return Users[id];
        }

        public Location GetLocation(int id)
        {
            throw new NotImplementedException();
            //return Locations[id];
        }

        public Visit GetVisit(int id)
        {
            throw new NotImplementedException();
            //return Visits[id];
        }
        
        // Aggregate

        public IEnumerable<Visit> GetVisits(int userId, 
            long? fromDate, 
            long? toDate,
            string country,
            int? toDistance)
        {
            throw new NotImplementedException();
        }

    }
}