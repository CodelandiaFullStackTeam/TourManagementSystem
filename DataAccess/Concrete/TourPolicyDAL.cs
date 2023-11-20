using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class TourPolicyDAL: BaseRepository<Tours_Policies, TourDbEntities>,ITourPolicyDAL { }
}