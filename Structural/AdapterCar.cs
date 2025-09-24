namespace DesignPatterns.Structural {
    // Adapter Pattern: Allows the interface of an existing class to be used as another interface.
    public interface IAdapterCar {
        string GetCarType();
    }
    public class Truck {
        public string GetTruckType() => "Heavy Truck";
    }
    public class TruckAdapter : IAdapterCar {
        private Truck _truck;
        public TruckAdapter(Truck truck) {
            _truck = truck;
        }
        public string GetCarType() => _truck.GetTruckType();
    }
}
