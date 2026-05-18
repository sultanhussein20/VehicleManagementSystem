using VehicleManagementSystem.Abstract;
namespace VehicleManagementSystem.Class
{
    public class Motorcycle : VehicleBase
    {
        public Motorcycle(string brand) : base(brand)
        {
        }

        public override void Stop()
        {
            Log("motor  stop...");
        }

       
    }
}
