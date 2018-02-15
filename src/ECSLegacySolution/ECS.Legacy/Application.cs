namespace ECS.Legacy
{
    public class Application
    {
        public static void Main()
        {
            var ecs = new ECS(28, new TempSensor(), new Heater(), new Window(10));

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
