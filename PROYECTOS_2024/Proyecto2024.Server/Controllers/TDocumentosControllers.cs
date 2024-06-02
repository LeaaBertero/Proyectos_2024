using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Proyecto2024.BD.Data;
using Proyecto2024.BD.Data.Entity;

//proyecto server - acá van los controllers
namespace Proyecto2024.Server.Controllers
{
    [ApiController]
    [Route("api/TDocumentos")]
    public class TDocumentosControllers : ControllerBase //Clase de Entity Framework Heredada
    {
        private readonly Context context;

        //constructor
        public TDocumentosControllers(Context context) //contxt es la base de datos
        {
            this.context = context;
        }

        //Método Get
        [HttpGet]
        public async Task<ActionResult<List<TDocumento>>> Get()
        {
            return await context.TDocumentos.ToListAsync();
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<TDocumento>> Get(int id) 
        {
            var Lean = await context.TDocumentos.FirstOrDefaultAsync(x => x.Id == id);

            if (Lean == null) 
            {
                return NotFound();
            }
            return Lean;
        }

        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id) 
        {
            //Existe = false;
            var existe = await context.TDocumentos.AnyAsync(x => x.Id == id);
            return existe;
            
        }

       

        

        //Método Post
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


        //Método Put
        [HttpPut("{id:int}")] //apis/Documentos/2
        public async Task<ActionResult> Put(int id, TDocumento entidad)
        {
            if (id != entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var lean = await context.TDocumentos.Where
                (e => entidad.Id == id).FirstOrDefaultAsync();

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

        //método para eliminar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.TDocumentos.AnyAsync(x => x.Id==id);

            if (!existe)
            {
                return NotFound($"El tipo de documento {id} no existe");
            }


            TDocumento EntidadBorrar = new TDocumento();
                
            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);
            await context.SaveChangesAsync();   
            return Ok();

        }
    }   
}

                


  
