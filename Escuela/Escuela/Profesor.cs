using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Profesor : Persona
    {
        private double _dbSueldo;


        public double Sueldo
        {
            get => _dbSueldo; set => _dbSueldo = value; 
        }

        public string Enseñar()
        {
            return Nombre + ", esta enseñando ahora...";
        }
    }
    
}