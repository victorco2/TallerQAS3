using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
   public class Periodo
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FInicio { get; set; }
        public DateTime FFinal { get; set; }
        public int Periodos { get; set; }


    }
}
