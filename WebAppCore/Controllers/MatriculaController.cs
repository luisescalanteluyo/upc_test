using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectData.Model;

namespace WebAppCore.Controllers
{
    [Route("v2/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {

        private ModelContext _context;

        public MatriculaController(ModelContext context)
        {
            _context = context;
        }

        [HttpGet("Cursos")]
        public async Task<IActionResult> Cursos()
        {
            var rpta = await _context.Curso.ToListAsync();

            return Ok(new Response { CódigoRetorno="200", DescRetorno ="ok", data= rpta });
        }


        [HttpGet("Matricula_Listado")]
        public IActionResult Matricula_Listado(string negocio, string modalidad, 
                                                string codigo_alumno, string periodo)
        {
          //  var rpta = await _context.Matricula.ToListAsync();


            var rpta =  (from mm in _context.Matricula
                     join detm in _context.Det_Matricula on mm.ID_MATRICULA equals detm.MATRICULA_ID_MATRICULA
                     join cc in _context.Curso on detm.CURSO_COD_CURSO equals cc.COD_CURSO
                     orderby detm.MATRICULA_ID_MATRICULA
                     where cc.COD_LINEA_NEGOCIO.ToUpper().Replace(" ", string.Empty) == negocio.ToUpper().Replace(" ", string.Empty)
                     && mm.COD_MODAL_EST.ToUpper().Replace(" ", string.Empty) == modalidad.ToUpper().Replace(" ", string.Empty)
                     && mm.COD_ALUMNO.ToUpper().Replace(" ", string.Empty) == codigo_alumno.ToUpper().Replace(" ", string.Empty)
                     && mm.COD_PERIODO.ToUpper().Replace(" ", string.Empty) == periodo.ToUpper().Replace(" ", string.Empty)

                         select new
                     {
                        mm
                    }).ToList();
             

            return Ok(new Response { CódigoRetorno = "200", DescRetorno = "ok", data = rpta });
        }


        [HttpGet("Det_Matriculas")]
        public async Task<IActionResult> Det_Matriculas()
        {
            var rpta = await _context.Matricula.ToListAsync();

            return Ok(new Response { CódigoRetorno = "200", DescRetorno = "ok", data = rpta });
        }




        [HttpPost("Registro_Matricula")]
        public IActionResult Registro_Matricula(  
         string COD_LINEA_NEGOCIO,
         string COD_MODAL_EST, 
         string COD_PERIODO, 
         string COD_ALUMNO  )
        {
            //  var rpta = await _context.Matricula.ToListAsync();


            Matricula objEmp = new Matricula();
            // fields to be insert
            objEmp.COD_LINEA_NEGOCIO = COD_LINEA_NEGOCIO;
            objEmp.COD_MODAL_EST = COD_MODAL_EST;
            objEmp.COD_PERIODO = COD_PERIODO;
            objEmp.COD_ALUMNO = COD_ALUMNO;

            _context.Matricula.Add(objEmp);

         int irpta=   _context.SaveChanges();

            Response rpta = null;

            if (irpta > 0)
                rpta = new Response { CódigoRetorno = "200", DescRetorno = "registro correcto", data = rpta };
            else
                rpta = new Response { CódigoRetorno = "400", DescRetorno = "registro incorrecto", data = rpta };



            return Ok(new Response { CódigoRetorno = "200", DescRetorno = "ok", data = rpta });
        }



    }


}
