using API.Service.Models;

namespace API.Service.Data.Repository
{
    public class CarRepository
    {

        private IList<Car> _cars;
        public CarRepository() => _cars = DataReader.RetriveCars();

        public IEnumerable<Car> GetAll() => _cars;

        public IEnumerable<Car> GetByStatus(string status) =>
            _cars.Where(c => c.Status.ToUpper().Equals(status.ToUpper()));

        public IEnumerable<Car> GetByYear(int year) => _cars.Where(c => c.Year == year);

        public IEnumerable<Car> GetByAmountRange(decimal minValue, decimal maxValue) => 
            _cars.Where(c => c.Cost >= minValue && c.Cost <= maxValue);
    }
}
