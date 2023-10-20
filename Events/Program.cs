namespace Events
{
    internal class Program
    {
        static void Fire(object sender)
        {
            Console.WriteLine("Пожар");
        }

        static void Main(string[] args)
        {
            Switcher sw = new Switcher();
            Lamp lamp = new Lamp();
            TvSet tv = new TvSet();

            // subscribe event
            //sw.ElectricityOn += new Electricity(lamp.LightOn);
            sw.ElectricityOn += lamp.LightOn;
            sw.ElectricityOn += tv.TvOn;

            //sw.ElectricityOn -= lamp.LightOn;
            sw.ElectricityOn += Program.Fire;

            sw.ElectricityOn += delegate (object sender)
            {
                Console.WriteLine("Всё сгорело");
            };
            
            // lambda
            sw.ElectricityOn += s => Console.WriteLine("Пожарные приехали");

            sw.SwitchOn();

            
        }
    }
}
