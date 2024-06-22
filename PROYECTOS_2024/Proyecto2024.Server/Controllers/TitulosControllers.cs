﻿using Microsoft.AspNetCore.Mvc;
using Proyecto2024.BD.Data.Entity;
using Proyecto2024.BD.Data;
using Microsoft.EntityFrameworkCore;

namespace Proyecto2024.Server.Controllers
{
    [ApiController]                
    [Route("api/Titulos")]         
    public class TitulosControllers : ControllerBase
    {

        //inicializacion de la clase Contextt que es readonly("de solo lectura").
        private readonly Context context;


        //Hacer el constructor del controller TDocumento
        //Constructor de la clase TDocumentoController
        public TDocumentosControllers(Context context) //contxt es la base de datos
        {
            this.context = context;
        }


        //Método Get = devuelve una lista de objetos de la clase TDocumentos
        [HttpGet] //Peticiones http o EndPoint's
        public async Task<ActionResult<List<TDocumento>>> Get()
        {
            return await context.TDocumentos.ToListAsync(); //El Context es la base de datos
            //devuelve una lista en forma asincronica
        }



        //Método Get
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

        //Método Get
        [HttpGet("{cod}")]
        public async Task<ActionResult<TDocumento>> GetByCod(string cod)
        {
            var Lean = await context.TDocumentos.FirstOrDefaultAsync(x => x.Codigo == cod);

            if (Lean == null)
            {
                return NotFound();
            }
            return Lean;
        }


        //Método Get -  para ver si existe el registro
        [HttpGet("existe/{id:int}")]
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
        public async Task<ActionResult> Put(int id, [FromBody] TDocumento entidad)
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
            var existe = await context.TDocumentos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound($"El tipo de documento {id} no existe..");
            }


            TDocumento EntidadBorrar = new TDocumento();

            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);
            await context.SaveChangesAsync();
            return Ok();


        }
    }              