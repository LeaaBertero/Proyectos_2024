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
    {                    //clase //argumento
        private readonly Context context;

        //contructor de la tabla usuarios             
        //Inyección de dependencia
        public UsuariosControllers(Context context) //tabla usuarioController, recibe como argumento el Context(La base de datos)
        {
            this.context = context;
        }


        // -------------------- END POINTS -------------------- //  

        //Método Get = (Retorna una lista de usuarios)
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuarios.ToListAsync();
            // retornar esperando al context(Base de datos, la lista asincronica de los usuarios)
        }


        //Método Post (datos que devuelve al server y el server le devuelve en forma de respuesta peticiones al front(Mensajes para el usuario))
        [HttpPost] //Inserta un registro a la base de datos
        public async Task<ActionResult<int>> Post(Usuario entidad)
        {
            //TryCatch - Por si se genera un error en la carga de datos del usuario
            try
            {
                //agrega la entidad (Usuarios a la base de datos en el método Post)
                context.Usuarios.Add(entidad);
                await context.SaveChangesAsync(); //para grabar los datos ingresados por el usuario en el servidor de base de datos
                return entidad.ID; //ID que viene de la clase (EntityBase), la cual ese ID, esta en todas las entidades
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        //Metodo Put
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int Id, [FromBody] Usuario entidad)
        {
            if (Id == entidad.ID)
            {
                return BadRequest("Datos incorrectos");
            }
            //recibe valores null
            Usuario? Lean = await context.Usuarios.
                Where(e => e.ID == Id).FirstOrDefaultAsync();

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


        //Método delete
        [HttpDelete("{id: int}")]
        public async Task<ActionResult> Delete(int id)
        {
            //pregunto si en la tabla Usuarios existe un registro x que cumple 
            //con la condicion de que el campo ID es igual al id que entro de argumento
            //si existe devuelve true, en caso contrario devuelve false (por ser booleano)
            var existe = await context.Usuarios.AnyAsync(x => x.ID == id);

            if (!existe)
            {
                return NotFound($"El usuario {id}, no existe");
            }

            //instanciando la entidad que quiero borrar
            Usuario EntidadABorrar = new Usuario();
            EntidadABorrar.ID = id; 

            context.Remove( EntidadABorrar );
            await context.SaveChangesAsync();
            return Ok();



        }



    }

    
}


