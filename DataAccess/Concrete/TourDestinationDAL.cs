using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class TourDestinationDAL: BaseRepository<Tours_Destinations, TourDbEntities>,ITourDestinationDAL { }
}