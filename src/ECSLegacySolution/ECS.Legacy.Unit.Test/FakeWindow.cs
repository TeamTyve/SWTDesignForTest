namespace ECS.Legacy.Unit.Test
{
    class FakeWindow : IWindow
    {
        public int Threshold {private get; set; }
        public bool WindowOpen { get; private set; }
        public void WindowCtrl(int temp = 0)
        {
            Threshold = 0;
            var bla = Threshold;
            WindowOpen = true;
        }
    }
}