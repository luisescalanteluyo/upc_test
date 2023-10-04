using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectData.Model
{
    public class Det_Matricula
    {
   
        public string? COD_PRODUCTO { get; set; }
        public string? SECCION { get; set; }
        public string? GRUPO { get; set; }
        public string? USUARIO_CREADOR { get; set; }
        public DateTime? FECHA_CREACION { get; set; }
        public string? USUARIO_MODIFICACION { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }

        [Key]
        public int? MATRICULA_ID_MATRICULA { get; set; }
        public string? CURSO_COD_LINEA_NEGOCIO { get; set; }
        public string? CURSO_COD_CURSO { get; set; }


    }
}
