using System;
using System.Collections.Generic;
using System.Linq;

namespace lists
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>()
            {"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // planetList.ForEach(planet => Console.WriteLine(planet));
            List<string> lastPlanets = new List<string>()
            {"Neptune", "Uranus"};
            planetList.AddRange(lastPlanets);
            // planetList.ForEach(planet => Console.WriteLine(planet));
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");
            // planetList.ForEach(planet => Console.WriteLine(planet));
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            // rockyPlanets.ForEach(planet => Console.WriteLine(planet));
            planetList.Remove("Pluto");
            // planetList.ForEach(planet => Console.WriteLine(planet));


            // Dictionary<string, string> Sputnik = new Dictionary<string, string>() {{"Venus","Sputnik 19"}};
            // Dictionary<string, string> Messenger = new Dictionary<string, string>() {{"Mercury","Messenger"}};
            // Dictionary<string, string> Giotto = new Dictionary<string, string>() {{"Earth","Giotto"}};
            // Dictionary<string, string> Ulysses = new Dictionary<string, string>() {{"Jupiter","Ulysses"}};
            // Dictionary<string, string> Voyager2 = new Dictionary<string, string>() {{"Neptune","Voyager 2"}};
            
            List<Dictionary<string, string>> ProbePlanetList = new List<Dictionary<string, string>>(); 

            Dictionary<string, string> Venus = new Dictionary<string, string>() {{"Sputnik 19", "Venus"}};
            //could also look like this
            //venus["Sputnik 19"] = "Venus"
            Dictionary<string, string> Mercury = new Dictionary<string, string>() {{"Messenger", "Mercury"}};
            //OR could also look like this
            //
            Dictionary<string, string> Earth = new Dictionary<string, string>() {{"Giotto","Earth"}};
            Dictionary<string, string> Jupiter = new Dictionary<string, string>() {{"Ulysses", "Jupiter"}};
            Dictionary<string, string> Neptune = new Dictionary<string, string>() {{"Voyager 2", "Neptune"}, {"Voyager 3", "Neptune"}};
            
            
            ProbePlanetList.Add(Venus);
            ProbePlanetList.Add(Mercury);
            ProbePlanetList.Add(Earth);
            ProbePlanetList.Add(Jupiter);
            ProbePlanetList.Add(Neptune);
        
        


        foreach (string planet in planetList)
        {
            List<string> visitedProbes  = new List<string>();
            foreach (Dictionary<string, string> item in ProbePlanetList)
            {
                    foreach (KeyValuePair<string, string> stuff in item)
                    {
                        if (stuff.Value == planet)
                        {
                            visitedProbes.Add(stuff.Key);
                        }   
    }

                }
                    /*
        Use String.Join(",", matchingProbes) as part of the
        solution to get the output below. It's the C# way of
        writing `array.join(",")` in JavaScript.
    */
                // string completedString = string.Join(", ", completedList);
                // Console.WriteLine("{0}: {1}", planet, completedString);
            foreach (string item in visitedProbes)
            {
                Console.WriteLine($"{planet}: {item}");
            }
   
   
        /*
            Does the current Dictionary contain the key of
            the current planet? Investigate the ContainsKey()
            method on a Dictionary.

            If so, add the current spacecraft to `matchingProbes`.
        */
    


   
}

        }
        
        
            
    }
}
