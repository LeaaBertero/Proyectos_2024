using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; //Using asignado por TaskListAsync(Generaba error al no estar presente en el return)
using Proyecto2024.BD.Data;
using Proyecto2024.BD.Data.Entity; //usings

namespace Proyecto2024.Server.Controllers
{
    //etiqueta de ApiController
    [ApiController]
    [Route("api/TDocumentos")]

    //Los controller de las tablas derivan(Heredan) de ControllerBase
    public class TDocumentosControllers : ControllerBase
    {   //------------------------------------ IMPORTANTE ----------------------------------------
        //Parados sobre el (context -- Presionar control . para crear y asgnar el campo (Context)), en las opciones que muestra(Seleccionarlo)
        private readonly Context context;
        //------------------------------------ IMPORTANTE ----------------------------------------


        //Hacer el constructor de el controller TDocumento, lo mismo para todos los registros(Tablas)
        //constructor del controller TDocumentos
        public TDocumentosControllers(Context context) //Recibe como argumento el context(La base de datos_ Le daremos como nombre (Context))
        {
            //Éste es el context(La base de datos)
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TDocumento>>> Get()
        {
            return await context.TDocumentos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(TDocumento entidad)
        {
            try
            {
                context.TDocumentos.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }

        //api/TDocumento 2
        [HttpPut("{id:int}")]    //Tarea: Resultado de acciones TDocumento entidad
        public async Task<ActionResult> Put(int id, [FromBody] TDocumento entidad)
        {
            if (id != entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            //expresion Lamda(Forma de codificación funcional)
            var respuesta = await context.TDocumentos
                .Where(e => entidad.Id == id).FirstOrDefaultAsync();

            if (respuesta == null)
            {
                return NotFound("NO existe el tipo de documento buscado");
            }

            respuesta.Codigo = entidad.Codigo;
            respuesta.Nombre = entidad.Nombre;
            respuesta.Activo = entidad.Activo;

            try
            {
                context.TDocumentos.Update(respuesta);
                await context.SaveChangesAsync();
                return Ok(respuesta);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        

    }
}
