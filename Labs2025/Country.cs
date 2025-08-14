using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2025
{
    internal class Country
    {
        private string _name;
        private int _square;
        private int _population;
        private string _capitalName;
        private int _capitalPopulation;

        public Country(string name, int square, int population, string capitalName, int capitalPopulation)
        {
            _name = name;
            _square = square;
            _population = population;
            _capitalName = capitalName;
            _capitalPopulation = capitalPopulation;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetSquare(int square)
        {
            _square = square;
        }

        public int GetSquare()
        {
            return _square;
        }

        public void SetPopulation(int population)
        {
            _population = population;
        }

        public int GetPopulation()
        {
            return _population;
        }

        public void SetCapitalName(string capitalName)
        {
            _capitalName = capitalName;
        }

        public string GetCapitalName()
        {
            return _capitalName;
        }

        public void SetCapitalPopulation(int capitalPopulation)
        {
            _capitalPopulation = capitalPopulation;
        }

        public int GetCapitalPopulation()
        {
            return _capitalPopulation;
        }

        public override string ToString()
        {
            return $"Country: {_name}\n" +
                $"Square(km^2): {_square}\n" +
                $"Population: {_population}\n" +
                $"Capital name: {_capitalName}\n" +
                $"Capital population: {_capitalPopulation}";
        }
    }
}
