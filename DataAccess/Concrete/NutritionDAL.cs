using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class NutritionDAL: BaseRepository<Nutrition, TourDbEntities>,INutritionDAL { }
}