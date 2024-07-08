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
    }
}
