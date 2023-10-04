using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectData.Model
{
    public class Curso
    {
        [Key]
        public string? COD_LINEA_NEGOCIO { get; set; } = "";
        public string? COD_CURSO { get; set; } = "";
        public string? DESC_CURSO { get; set; } = "";
        public string? USUARIO_CREADOR { get; set; } = "";
        public DateTime? FECHA_CREACION { get; set; }
        public string? USUARIO_MODIFICACION { get; set; } = "";
        public DateTime? FECHA_MODIFICACION { get; set; }

    }
}
