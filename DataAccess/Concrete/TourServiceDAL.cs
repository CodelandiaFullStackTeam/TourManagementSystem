using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class TourServiceDAL: BaseRepository<Tours_Services, TourDbEntities> ,ITourServiceDAL{ }
}