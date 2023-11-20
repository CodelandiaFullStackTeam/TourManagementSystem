using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class PositionDAL: BaseRepository<Position, TourDbEntities>,IPositionDAL { }
}