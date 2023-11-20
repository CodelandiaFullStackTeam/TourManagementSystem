using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class CategoryDAL: BaseRepository<Category, TourDbEntities>,ICategoryDAL { }
}