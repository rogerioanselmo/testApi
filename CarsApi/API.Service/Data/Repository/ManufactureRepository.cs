using API.Service.Models;

namespace API.Service.Data.Repository
{
    public class ManufactureRepository
    {
        private readonly IList<Manufacture> _manufactureList;

        public ManufactureRepository() => _manufactureList = DataReader.RetriveManufaturers();

        public IEnumerable<Manufacture> GetAll() => _manufactureList;
    }
}
