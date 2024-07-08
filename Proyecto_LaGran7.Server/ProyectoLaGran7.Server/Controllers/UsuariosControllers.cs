using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;
using ProyectoLaGran7.BD.Data.Entity; //Using de controllers

//lugar donde se encuentra ubicado el archivo(Ruta de acceso)
namespace ProyectoLaGran7.Server.Controllers
{
    //EndPoint Usuarios(Peticion GET)
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosControllers : ControllerBase //Clase del framework que hereda de la clase UsuarioControllers
    {
        private readonly Context context;

        //contructor de la tabla usuarios             
                                   //Inyección de dependencia
        public UsuariosControllers(Context context) //tabla usuarioController, recibe como argumento el Context(La base de datos)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> Get() 
        {
             return await context.Usuarios.ToListAsync();   
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Usuarios entidad) 
        {
            try
            {
                context.Usuarios.Add(entidad);
                await context.SaveChangesAsync(); //para grabar los datos ingresados por el usuario en el servidor de base de datos
                return entidad.ID;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                
            }
        }

        //Metodo Put
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int Id,[FromBody] Usuarios entidad) 
        {
            if (Id == entidad.ID)
            {
                return BadRequest("Datos incorrectos");
            }
            //recibe valores null
            Usuarios? Lean = await context.Usuarios.
                Where(e => e.ID==Id).FirstOrDefaultAsync();

            if (Lean == null) 
            {
                return NotFound("No existe el usuario buscado");  
            }

            Lean.Nombre = entidad.Nombre;
            Lean.Mail = entidad.Mail;
            Lean.Contraseña = entidad.Contraseña;
            Lean.Rol = entidad.Rol;


            try
            {
                context.Usuarios.Update(Lean);
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


