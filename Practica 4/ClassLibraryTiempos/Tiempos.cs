using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTiempos
{
    public class Tiempos
    {
        public enum Dias
        {
            Domingo,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        };

        public enum Horas
        {
            one=1, two=2, three=3, four=4, five=5, six=6, seven=7, eight=8, nine=9, ten=10, eleven=11, twelve=12,
        }
        public enum Horarios
        {
            AM, PM
        }
    }
}
