using API.Service.ConfigSections;
using API.Service.Data.Repository;
using API.Service.Extensions;
using API.Service.Models;

namespace API.Service.Service
{
    public class CarService
    {
        private CarRepository _carRepository;
        private readonly IConfiguration _configuration;

        public CarService(CarRepository carRepository, IConfiguration configuration)
        {
            _carRepository = carRepository;
            _configuration = configuration;
        }

        public IEnumerable<Car> GetAll() => _carRepository.GetAll();

        public IEnumerable<Car> GetByStatus(string status)
        {
            if (!status.IsValidStatus())
                throw new Exception($"the status {status} is not valid");

            return _carRepository.GetByStatus(status);
        }

        public IEnumerable<Car> GetByYear(int year)
        {
            var minimalYear = _configuration.GetValue<int>("minimalYear");
            if (!year.IsVaidYear(minimalYear))
                throw new Exception($"the year {year} is not valid. Try something betwenn {minimalYear} and {DateTime.Now.Year}");

            return _carRepository.GetByYear(year);
        }

        public IEnumerable<Car> GetByAmount(decimal amountValue)
        {
            var amountInfo = _configuration.GetSection("Amount").Get<AmountSection>();
            if (!amountValue.IsVaidAmount(amountInfo))
                throw new Exception($"the amount {amountValue} is not valid. Try something betwenn {amountInfo.MinValue} and {amountInfo.MaxValue}");

            return _carRepository.GetByAmountRange(amountInfo.MinValue, amountValue);
        }
    }
}
