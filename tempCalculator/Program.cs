using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempCalculator
{
    public class Temperatura
    {
        private double _Celsius = 0;

        public double Celsius
        {
            get { return _Celsius; }
            set
            {
                _Celsius = value;
            }
        }
        private double _Fahrenheit = 0;
        public double Fahrenheit
        {
            get { return _Fahrenheit; }
            set
            {
                _Fahrenheit = value;
            }
        }
        private double _Kelvin = 0;
        public double Kelvin
        {
            get { return _Kelvin; }
            set
            {
                _Kelvin = value;
            }
        }


        public static void Add(Temperatura temp)
        {

        }

    }
}
