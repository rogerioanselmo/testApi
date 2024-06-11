using API.Service.Data.Repository;
using API.Service.Models;

namespace API.Service.Service
{
    public class ManufactureService
    {
        private readonly ManufactureRepository _manufactureRepository;

        public ManufactureService(ManufactureRepository manufactureRepository) => 
            _manufactureRepository = manufactureRepository;

        public IEnumerable<Manufacture> GetAll() => _manufactureRepository.GetAll();
    }
}
