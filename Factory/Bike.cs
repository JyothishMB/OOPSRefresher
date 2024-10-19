namespace Factory
{
    public class Bike : IVehicle
    {
        private readonly int NumberOfWheels;
        public Bike()
        {
            this.NumberOfWheels = 2;
        }
        public int GetNumberOfWheels()
        {
            return this.NumberOfWheels;
        }

        public string GetVehicleType()
        {
            return "Bike";
        }
    }
}
