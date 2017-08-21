using dotnetapp.Entities;

namespace dotnetapp.Code
{
    public interface IRepository
    {
        void AddUser(User user);
        void AddVisit(Visit visit);
        void AddLocation(Location location);

        User GetUser(int id);
        Location GetLocation(int id);
        Visit GetVisit(int id);
        
        void UpdateLocation(int id, Location location);
        void UpdateUser(int id, User user);
        void UpdateVisit(int id, Visit visit);
    }
}