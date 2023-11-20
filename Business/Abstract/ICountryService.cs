using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagementSystem.Business.Abstract
{
    public interface ICountryService
    {
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
        IDataResult<Country> GetById(int id);
        IDataResult<List<Country>> GetAll();
    }
}
