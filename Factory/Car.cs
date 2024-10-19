namespace Factory
{
    public class Car : IVehicle
    {
        private readonly int NumberOfWheels;
        public Car()
        {
            this.NumberOfWheels = 4;
        }
        public int GetNumberOfWheels()
        {
            return this.NumberOfWheels;
        }

        public string GetVehicleType()
        {
            return "Car";
        }
    }
}
