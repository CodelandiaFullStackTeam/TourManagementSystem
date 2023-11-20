using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class TourDAL: BaseRepository<Tour, TourDbEntities>,ITourDAL { }
}