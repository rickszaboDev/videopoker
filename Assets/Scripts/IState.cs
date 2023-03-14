namespace RickSzaboDev.Patterns
{
    public interface IState
    {
        void Tick();
        void OnEnter();
        void OnExit();
    }
}