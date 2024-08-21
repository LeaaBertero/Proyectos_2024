﻿using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc; //Model View Controller
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Server.Repositorio;
using Proyecto_LaGranSiete.Shared.DTO;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Usuarios")] //Ruta de controllers
    public class UsuariosControllers : ControllerBase
    {
        private readonly IUsuarioRepositorio repositorio;

        //crear y asignar campo context

        private readonly IMapper mapper;

        //constructor
        public UsuariosControllers(IUsuarioRepositorio repositorio,
            IMapper mapper) //<--(inyección de dependencia)

        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get() //Task == "Tarea"
        {
            return await repositorio.Select();
        }

        //get 1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            Usuario? VariableAuxiliar = await repositorio.SelectById(id);

            if (VariableAuxiliar == null)
            {
                return NotFound();
            }

            return VariableAuxiliar;
        }

        //get 2
        //[HttpGet("GetByCod/{cod}")]
        //public async Task<ActionResult<Usuarios>> GetByCod(string cod)
        //{
        //    Usuarios? lean = await context.Usuarios
        //        .FirstOrDefaultAsync(x => x.Nombre == cod);

        //    if (lean == null)
        //    {
        //        return NotFound();
        //    }

        //    return lean;
        //}




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await repositorio.Existe(id);
            return existe;
        }
        

        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearUsuariosDTO entidadDTO)
        {
            try
            {
                Usuario entidad = mapper.Map<Usuario>(entidadDTO);
                return await repositorio.Insert(entidad); //Id de la entidad 
            }
            catch (Exception ErrorMessage)
            {
                return BadRequest(ErrorMessage.Message);
                //throw;
            }
        }
            

        [HttpPut("{id:int}")] //Api / Usuarios
        public async Task<ActionResult> Put(int id, [FromBody] Usuario entidad) 
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var Lean = await repositorio.SelectById(id);

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
                await repositorio.Update(id, Lean);
                
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
            var existe = await repositorio.Existe(id);

            if (!existe) 
            {
                return NotFound($"El usuario buscado {id}, no se encuentra");
            }
            if (await repositorio.Borrar(id))
            {
                return Ok();

            }
            else 
            {
                return BadRequest();
            }
        }
    }
}





        
        
