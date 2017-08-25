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
            model.SaveChanges();
        }

        public void AddUsers(IEnumerable<User> users){
            model.AddRange(users);
            model.SaveChanges();
        }

        public void AddVisit(Visit visit)
        {
            model.Visits.Add(visit);
            model.SaveChanges();
        }

        public void AddVisits(IEnumerable<Visit> visits){
            model.Visits.AddRange(visits);
            model.SaveChanges();
        }

        public void AddLocation(Location location)
        {
            model.Locations.Add(location);
            model.SaveChanges();
        }

        public void AddLocations(IEnumerable<Location> locations){
            model.Locations.AddRange(locations);
            model.SaveChanges();
        }

        // Update

        public void UpdateUser(User user)
        {
            model.Users.Update(user);
            model.SaveChanges();
        }

        public void UpdateVisit(Visit visit)
        {
            model.Visits.Update(visit);
            model.SaveChanges();
        }

        public void UpdateLocation(Location location)
        {
            model.Locations.Update(location);
            model.SaveChanges();
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