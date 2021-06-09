using System;

namespace Sess4App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            float Earth_OrbitalPer = 31557600; 

            Console.WriteLine("What's the EarthAge: ");
            
            float x = Convert.ToInt32(Console.ReadLine());

            float SpaceTrav_EarthAge = x/Earth_OrbitalPer;

            Console.WriteLine("SpaceTrav_EarthAge:  {0} Earth-Years Old", SpaceTrav_EarthAge);  // why anything else brings error 'Unhandled exception. System.FormatException: Input string was not in a correct format.'
            
            string [] Planets = new string [4];
            Planets [0] = "Venus";
            Planets [1] = "Mars";
            Planets [2] = "Jupiter";
            Planets [3] = "Neptune";

            float [] orbital_period = new float [4];
            orbital_period [0] = 0.61519726f;
            orbital_period [1] = 1.8808158f;
            orbital_period [2] = 11.862615f;
            orbital_period [3] = 164.79132f;

            for (int i = 0; i<= orbital_period.Length; i++ )
            {
            
                foreach (var item in Planets)
                {                   

                    float y = (orbital_period [i]) * SpaceTrav_EarthAge;
                    //Console.WriteLine("{0} Age: {1} Earth-Years Old", Planets[i], y);  //why item fail to be refence to index planets array compnents...?

                    Console.WriteLine("SpaceTrav_EarthAge:  {0} Earth-Years Old - {1} Age: {2} Earth-Years Old", SpaceTrav_EarthAge, Planets[i], y);

                    if (i <= 4)
                    {break; }

                }
                
            }


        }


        //static float getValue(float _x)
        // {
        //     float SpaceTrav_EarthAge = _x/EarthYears;
            
        //     Console.WriteLine("SpaceTrav_EarthAge:  {SpaceTrav_EarthAge}", SpaceTrav_EarthAge);

        //     float SpaceTrav_EarthAge = _x/EarthYears;

        //     return SpaceTrav_EarthAge;
        // }

    }
}
