namespace DesignPatterns.Creational {
    // Singleton Pattern: Ensures a class has only one instance and provides a global point of access to it.
    public class SingletonCar {
        private static SingletonCar? _instance;
        public string Model { get; private set; }
        private SingletonCar(string model) {
            Model = model;
        }
        public static SingletonCar GetInstance(string model) {
            if (_instance == null) {
                _instance = new SingletonCar(model);
            }
            return _instance;
        }
    }
}
