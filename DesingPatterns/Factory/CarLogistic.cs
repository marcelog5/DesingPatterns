namespace DesingPatterns.Factory
{
    public class CarLogistic : Logistic
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
