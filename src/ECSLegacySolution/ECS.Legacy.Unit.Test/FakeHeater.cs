namespace ECS.Legacy.Unit.Test
{
    public class FakeHeater : IHeater
    {
        public bool TurnedOn { get; set; }

        public void TurnOn()
        {
            TurnedOn = true;
        }

        public void TurnOff()
        {
            TurnedOn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}