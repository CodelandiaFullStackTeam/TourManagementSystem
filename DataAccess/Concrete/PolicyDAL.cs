using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class PolicyDAL: BaseRepository<Policy, TourDbEntities>,IPolicyDAL { }
}