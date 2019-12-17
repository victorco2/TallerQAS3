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
    public class NCursos
    {
        public static DataTable Seleccionar()
        {
            DCurso Datos = new DCurso();
            return Datos.Seleccionar();
        }
        public static string insertar(string Nombre_Curso, int Cupo,int Id_periodo)
        {
            DCurso Datos = new DCurso();

            Curso Obj = new Curso();

            Obj.Nombre_Curso = Nombre_Curso;
            Obj.Cupo = Cupo;
            Obj.Id_periodo = Id_periodo;

            return Datos.Insertar(Obj);

        }
    }
}
