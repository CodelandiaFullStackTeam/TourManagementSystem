using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourManagementSystem.Business.Abstract;
using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.DataAccess.Concrete;
using TourManagementSystem.Helpers;

namespace TourManagementSystem.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        private readonly ICountryDAL _countryDAL;

        public CountryManager()
        {
            _countryDAL = new CountryDAL();
        }
        public IResult Add(Country country)
        {
            _countryDAL.Add(country);
            return new SuccessResult(CommonOperationMessages.DataAddedSuccessfully);
        }

        public IResult Delete(Country country)
        {
            _countryDAL.Delete(country);
            return new SuccessResult(CommonOperationMessages.DataDeletedSuccessfulyy);
        }

        public IDataResult<List<Country>> GetAll()
        {
           return new SuccessDataResult<List<Country>>(_countryDAL.GetAll());
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_countryDAL.Get(x => x.ID == id));
        }

        public IResult Update(Country country)
        {
            _countryDAL.Update(country);
            return new SuccessResult(CommonOperationMessages.DataUpdatedSuccessfully);
        }
    }
}