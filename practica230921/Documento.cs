using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica230921
{
    class Orden
    {

        //definir miembros
        // propiedades 

      public string _ID { get; set; }
      public string _Fecha { get; set; }
      public string _Descripcion { get; set; }


        

        

        //metodo constructor
        public Orden(string id, string fecha, string descripcion) //metodo constructor vacio
        {
            _ID = id;
            _Fecha = fecha;
            _Descripcion = descripcion;
            
        }

        public string ObtenerDatos()
        {
            return "ID: " + _ID + " Fecha: " + _Fecha + " Descripcion : "
                + _Descripcion;  
        }
    }

       
    }

