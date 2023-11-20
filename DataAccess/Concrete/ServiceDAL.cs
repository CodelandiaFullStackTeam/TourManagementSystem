using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class ServiceDAL: BaseRepository<Service, TourDbEntities>,IServiceDAL { }
}