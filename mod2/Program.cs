namespace mod2
{
    enum Figures { Romb, Circle, Rect }

    struct FData
    {
        public int X, Y;
        public int Color;
        public Figures Type;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*FData fd;
            fd.X = 10;
            fd.Y = 20;
            fd.Color = 0x2727FF;
            fd.Type = Figures.Romb;*/
            FData fd = new FData()
            {
                X = 10,
                Y = 20,
                Color = 0x2727FF,
                Type = Figures.Romb
            };
            Console.WriteLine($"({fd.X}, {fd.Y}) {fd.Color} {fd.Type}");
        }
    }
}
