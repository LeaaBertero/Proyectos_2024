﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Usuarios")]
    public class UsuariosControllers : ControllerBase
    {
        //crear y asignar campo context
        private readonly Context context;

        //constructor
        public UsuariosControllers(Context Context) //<--(inyección de dependencia)
        {
            context = Context;
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
    }
}
