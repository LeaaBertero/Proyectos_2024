using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;
using Proyecto2024.BD.Data.Entity;

//proyecto server - acá van los controllers
namespace Proyecto2024.Server.Controllers
{
    [ApiController]
    [Route("api/TDocumentos")]
    public class TDocumentosControllers : ControllerBase
    {
        private readonly Context context;

        public TDocumentosControllers(Context context)
        {
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

        [HttpPut("{id: int}")] //apis/Documentos/2
        public async Task<ActionResult>Put(int id, TDocumento entidad) 
        {
            if (id != entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var lean = await context.TDocumentos.Where
                (e=> entidad.Id == id).FirstOrDefaultAsync();
        
            if (lean == null) 
            {
                return NotFound("No existe el tipo de documento buscado");
            }

            lean.Codigo = entidad.Codigo;
            lean.Nombre = entidad.Nombre;
            //lean.activo = entidad.acivo

            try
            {
                context.TDocumentos.Update(lean);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }   
}

                


  
