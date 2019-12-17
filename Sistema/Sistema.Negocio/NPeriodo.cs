using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPeriodo



    {

        public static string Insertar(string Descripcion, DateTime Finicio,DateTime Ffinal,int Periodos) {

            DPeriodo Datos = new DPeriodo();

            Periodo Obj = new Periodo();

            Obj.Descripcion = Descripcion;
            Obj.FInicio = Finicio;
            Obj.FFinal = Ffinal;
            Obj.Periodos = Periodos;

            return Datos.Insertar(Obj);
        }
    }
}
