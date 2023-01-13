
namespace SolarSystem
{
    internal class PlanetsCatalog
    {
        public List<Planet> Planets { get; }
        private int count = 1;

        public PlanetsCatalog()
        {
            Planets = new List<Planet>();
        }

        public PlanetsCatalog(Planet planet1, Planet planet2, Planet planet3)
        {
            Planets = new List<Planet>();
            Planets.Add(planet1);
            Planets.Add(planet2);
            Planets.Add(planet3);
        }

        public (string, int, int) GetPlanet(string name)
        {
            if (count == 3)
            {
                count = 1;
                return ("Вы спрашиваете слишком часто.", 0, 0);
            }

            foreach (var planet in Planets)
            {
                if (planet.Name == name)
                {
                    count++;
                    return (null, planet.Number, planet.EquatorLenth);
                }
            }

            count++;
            return ("Не удалось найти планету.", 0, 0);
        }
    }
}