using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectData.Model
{
    public class Matricula
    {
        [Key]
        public int? ID_MATRICULA { get; set; }
        public string? COD_LINEA_NEGOCIO { get; set; }
        public string? COD_MODAL_EST { get; set; }
        public string? COD_PERIODO { get; set; }
        public string? COD_ALUMNO { get; set; }
        
        public string? USUARIO_CREADOR { get; set; }
        public DateTime? FECHA_CREACION { get; set; }
        public string? USUARIO_MODIFICACION { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }



    }
}
