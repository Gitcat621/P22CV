using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Clases
{
    internal class Estudios
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int AnioFundacion { get; set; }
        public string Fundador { get; set; }
        public string MejorFranquicia { get; set; }
    }
}
