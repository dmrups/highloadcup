using System.Collections.Generic;
using dotnetapp.Entities;

namespace dotnetapp.Code
{
    public interface IRepository
    {
        void AddUser(User user);
        void AddUsers(IEnumerable<User> users);

        void AddVisit(Visit visit);
        void AddVisits(IEnumerable<Visit> visits);

        void AddLocation(Location location);
        void AddLocations(IEnumerable<Location> locations);

        User GetUser(int id);
        Location GetLocation(int id);
        Visit GetVisit(int id);
        
        void UpdateLocation(Location location);
        void UpdateUser(User user);
        void UpdateVisit(Visit visit);
    }
}