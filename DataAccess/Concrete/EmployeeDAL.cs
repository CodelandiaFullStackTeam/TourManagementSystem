using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class EmployeeDAL: BaseRepository<Employee, TourDbEntities>,IEmployeeDAL { }
}