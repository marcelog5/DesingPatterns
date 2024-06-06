namespace DesingPatterns.Factory
{
    public class TruckLogistic : Logistic
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
