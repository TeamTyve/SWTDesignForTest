namespace ECS.Legacy
{
    public class ECS : IECS
    {
        public int Threshold { get; set; }
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;
        private readonly IWindow _window;

        public ECS(int thr, ITempSensor tempSensor, IHeater heater, IWindow window)
        {
            _tempSensor = tempSensor;
            _heater = heater;
            _window = window;

            SetThreshold(thr);
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < Threshold)
            {
                _heater.TurnOn();
            }
            else
            {
                _heater.TurnOff();
            }

            _window.WindowCtrl(GetCurTemp());

        }

        public void SetThreshold(int thr)
        {
            Threshold = thr;
            _window.Threshold = thr;
        }

        public int GetThreshold()
        {
            return Threshold;
        }

        public int GetCurTemp()
        {
            return 0;
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
