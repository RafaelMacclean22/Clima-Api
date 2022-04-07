using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima_Api.Clases
{
    public class Conversiones
    {
        public static float ConvertirDeKelvinACelsius(float Kelvin )
        {
            return (Kelvin - 273.15f);
        }

        public static float ConvertirDeMillasAKm(float millas)
        {
            return (millas *3.6f);
        }

    }
}
