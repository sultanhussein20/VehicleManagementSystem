using VehicleManagementSystem.Abstract;

namespace VehicleManagementSystem.Class
{
    public class Car : VehicleBase
    {
        public override void Stop()
        {
            Log("car stop...");
        }
        public override double CalculateFuleConsumption(double distance)
        {
            double baseC= base.CalculateFuelConsumption(distance) ;
            var resulte = baseC * 1.10;
            return resulte;
        }
        public Car(string brand) : base(brand)
        {
        }
    }
}
