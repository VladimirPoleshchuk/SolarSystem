
namespace SolarSystem
{
    internal class Program
    {
        static void Main()
        {
            Planet venurs = new("Венера", 2, 12100, null);
            Planet earth = new("Земля", 3, 12756, venurs);
            Planet mars = new("Марс", 4, 6792, earth);

            PlanetsCatalog planets = new PlanetsCatalog(venurs, earth, mars);


            List<string> names = new List<string>() { "Земля", "Лимония", "Марс", "Венера" };

            foreach (var name in names)
            {
                PrintResultPlanet(name);
            }

            void PrintResultPlanet(string name)
            {
                var tuple = planets.GetPlanet(name);

                if (tuple.Item1 == null)
                {
                    Console.WriteLine($"[{tuple.Item2} {tuple.Item3}]");
                }

                Console.WriteLine(tuple.Item1);
            }

            //var venurs = new { Name = "Венера", Number = 2, equatorLenth = 12100, previousPlanet = "null" };
            //var earth = new { Name = "Земля", Number = 3, equatorLenth = 12756, previousPlanet = venurs };
            //var mars = new { Name = "Марс", Number = 4, equatorLenth = 6792, previousPlanet = earth };

            //Print(venurs);
            //Print(earth);
            //Print(mars);

            //bool GetEqualsPlanet(Object planet)
            //{
            //    venurs = new { Name = "Венера", Number = 2, equatorLenth = 12100, previousPlanet = "null" };
            //    return planet.Equals(venurs);
            //}

            //void Print(object planet)
            //{
            //    Console.WriteLine(planet + ": " + GetEqualsPlanet(planet));              
            //}
        }

    }
}