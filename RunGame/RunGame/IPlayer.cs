namespace RunGame
{
    interface IPlayer
    {
        void Run();
        void Gole();
        void NoGole();
        bool IsCatch(object obj);
    }
}
