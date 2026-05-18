using VehicleManagementSystem.Interface;

namespace VehicleManagementSystem.Abstract
{
    public abstract class VehicleBase : IVehicle
    {
        public virtual double CalculateFuleConsumption(double distance)
        {
            return distance / 10;
        }




        public virtual void Start()
        {
            Log("vehicle started....");
        }

        public abstract void Stop();

        public string Brand { get; set; }
        public VehicleBase(string brand)
        {
            Brand = brand;
        }
        public void Log(string message)
        {
            Console.WriteLine($"{Brand}**{message}");
        }

        public virtual double CalculateFuelConsumption(double distance)
        {
            return distance * 0.1;
        }
    }
}
