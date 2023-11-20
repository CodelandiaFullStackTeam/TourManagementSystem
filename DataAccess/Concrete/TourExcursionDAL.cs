using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class TourExcursionDAL: BaseRepository<Tours_Excursions, TourDbEntities>,ITourExcursionDAL { }
}