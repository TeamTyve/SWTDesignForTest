namespace ECS.Legacy
{
    public interface IECS
    {
        int GetCurTemp();
        int GetThreshold();
        void Regulate();
        bool RunSelfTest();
        void SetThreshold(int thr);
    }
}