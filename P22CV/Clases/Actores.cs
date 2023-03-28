using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Clases
{
    public class Actores
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string PersonajeFamoso { get; set; }
        public string PeliculaFamosa { get; set; }

        #region Atributos FechadeNacimiento
        //Atributos de la Fecha de nacimiento
        public int Año { get; set; }
        public string MesNacimiento { get; set; }
        public string DiaNacimiento { get; set; }
        #endregion
    }
}
