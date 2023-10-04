using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectData.Model
{
    public class Response
    {
        public string? CódigoRetorno { get; set; }
        public string? DescRetorno { get; set; }

        public object? data { get; set; }
    }
}
