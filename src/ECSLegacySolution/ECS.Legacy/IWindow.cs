namespace ECS.Legacy
{
    public interface IWindow
    {
        int Threshold { set; }
        bool WindowOpen { get; }

        void WindowCtrl(int temp = 0);
    }
}