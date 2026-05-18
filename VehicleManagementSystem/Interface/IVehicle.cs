namespace VehicleManagementSystem.Interface
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        double CalculateFuleConsumption(double distance);

    }
}