namespace autoclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto skoda, passat;
            skoda = new Auto("AB-CD-123", "Skoda SuperB", 5.23, 16000);
            passat = new Auto("XYZ-789", "VW Passat", 6.97, 13000, 256000);

            Console.WriteLine(skoda);
            Console.WriteLine(passat);
            for (int i = 1; i < 30; i++)
            {
                if (skoda.KellSzervizelni())
                {
                    skoda.szervizElvegzese();
                    Console.WriteLine("SZERVIZ!");
                }
                skoda.Menj(1000);
                Console.WriteLine($"{i+1}.{skoda}");
            }
        }
    }
}
