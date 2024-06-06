namespace DesingPatterns.Factory
{
    public abstract class Logistic
    {
        public abstract IVehicle CreateVehicle();

        public void StartRoute()
        {
            IVehicle vehicle = CreateVehicle();
            vehicle.ExitOperation();
        }
    }
}
