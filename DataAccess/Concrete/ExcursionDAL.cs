using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class ExcursionDAL: BaseRepository<Excursion, TourDbEntities>,IExcursionDAL { }
}