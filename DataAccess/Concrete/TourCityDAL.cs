using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class TourCityDAL: BaseRepository<Tours_Cities, TourDbEntities>,ITourCityDAL { }
}