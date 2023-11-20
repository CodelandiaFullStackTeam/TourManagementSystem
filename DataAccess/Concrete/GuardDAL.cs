using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class GuardDAL: BaseRepository<Guard, TourDbEntities>,IGuardDAL { }
}