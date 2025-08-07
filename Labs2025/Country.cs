using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2025
{
    internal class Country
    {
        string _name;
        int _square;
        int _population;
        string _capitalName;
        int _capitalPopulation;

        public Country(string name, int square, int population, string capitalName, int capitalPopulation)
        {
            _name = name;
            _square = square;
            _population = population;
            _capitalName = capitalName;
            _capitalPopulation = capitalPopulation;
        }

        public string GetString()
        {
            return $"Country: {_name}\n" +
                $"Square(km^2): {_square}\n" +
                $"Population: {_population}\n" +
                $"Capital name: {_capitalName}\n" +
                $"Capital population: {_capitalPopulation}";
        }
    }
}
