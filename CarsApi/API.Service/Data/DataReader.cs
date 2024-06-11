using API.Service.Models;
using System.Text.Json;

namespace API.Service.Data
{
    public static class DataReader
    {
        private static IList<Manufacture> _manufacturers;
        private static IList<Car> _cars;
        private static DataModel _dataModel;
        private static DataModel ReadFromFile()
        {
            if (_dataModel == null)
            {
                string filePath = $"{Directory.GetCurrentDirectory()}\\Data\\data.json";

                string jsonString = File.ReadAllText(filePath);
                _dataModel = JsonSerializer.Deserialize<DataModel>(jsonString);
            }

            return _dataModel;
        }

        public static IList<Manufacture> RetriveManufaturers()
        {
            if (_manufacturers == null)
            {
                var dataModel = ReadFromFile();
                _manufacturers = dataModel.Inventory;

            }
            return _manufacturers;
        }

        public static IList<Car> RetriveCars()
        {
            if (_cars == null)
            {
                var manufacturers = ReadFromFile().Inventory;

                _cars = manufacturers.SelectMany(manu => manu.Cars
                                                .Select(car =>
                                                {
                                                    car.Manufaturer = manu.Name;
                                                    return car;
                                                }
                                                )).ToList();
            }

            return _cars;
        }


    }
}
