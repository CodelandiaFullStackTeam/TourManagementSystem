using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Abstract
{
    public interface ICountryDAL : IBaseRepository<Country>
    {
    }

}
