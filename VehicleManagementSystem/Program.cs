using VehicleManagementSystem.Class;

Car car = new Car("Toyota");
Motorcycle motorcycle = new Motorcycle("honda");
car.Start();
car.Stop();
car.CalculateFuleConsumption(20);
Console.WriteLine($"Car Fule : {car.CalculateFuleConsumption(100)}");