using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Usuarios")] //Ruta de controllers
    public class UsuariosControllers : ControllerBase
    {
        //crear y asignar campo context
        private readonly Context context;

        //constructor
        public UsuariosControllers(Context Context) //<--(inyección de dependencia)
        {
            context = Context;
        }

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> Get() //Task == "Tarea"
        {
            return await context.Usuarios.ToListAsync();
        }

        //get 1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuarios>> Get(int id)
        {
            Usuarios? lean = await context.Usuarios
                .FirstOrDefaultAsync(x => x.Id == id);

            if (lean == null)
            {
                return NotFound();
            }

            return lean;
        }

        //get 2
        [HttpGet("GetByCod/{cod}")]
        public async Task<ActionResult<Usuarios>> GetByCod(string cod)
        {
            Usuarios? lean = await context.Usuarios
                .FirstOrDefaultAsync(x => x.Nombre == cod);

            if (lean == null)
            {
                return NotFound();
            }

            return lean;
        }




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await context.Usuarios.AnyAsync(x => x.Id == id);
            return existe;
        }
        

        [HttpPost]
        public async Task<ActionResult<int>> Post(Usuarios entidad)
        {
            try
            {
                context.Usuarios.Add(entidad);
                await context.SaveChangesAsync(); //espera y guarda los cambios del context
                return entidad.Id; //Id de la entidad 
            }
            catch (Exception ErrorMessage)
            {
                return BadRequest(ErrorMessage.Message);
                //throw;
            }
        }

        [HttpPut("{id:int}")] //Api / Usuarios
        public async Task<ActionResult> Put(int id, [FromBody] Usuarios entidad) 
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var Lean = await context.Usuarios.Where(e => e.Id == id).FirstOrDefaultAsync();

            if (Lean == null)
            {
                return NotFound("No existe el usuario buscado");
            }

            Lean.Nombre = entidad.Nombre;
            Lean.Apellido = entidad.Apellido;
            Lean.FechaNacimiento = entidad.FechaNacimiento;
            Lean.Telefono = entidad.Telefono;
            Lean.CorreoElectronico = entidad.CorreoElectronico;
            Lean.Parentesco = entidad.Parentesco;

            try
            {
                context.Usuarios.Update(Lean);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
                //throw;
            }
        }

        //Delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id) 
        {                                            //(expresión en lambda)
            var existe = await context.Usuarios.AnyAsync(x =>x.Id == id);

            if (!existe) 
            {
                return NotFound($"El usuario buscado {id}, no se encuentra");
            }

            Usuarios EntidadBorrar = new Usuarios();
            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);

            await context.SaveChangesAsync();

            return Ok();
        }
        
        
    }
}
