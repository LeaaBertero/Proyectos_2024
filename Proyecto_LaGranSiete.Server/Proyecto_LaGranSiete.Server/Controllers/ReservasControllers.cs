using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Shared.DTO;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Reservas")] //Ruta de controllers

    public class ReservasControllers : ControllerBase
    {
        private readonly Context context;
        private readonly IMapper mapper;

        public ReservasControllers(Context Context, IMapper mapper)
        {
            context = Context;
            this.mapper = mapper;
        }

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Reservas>>> Get() //Task == "Tarea"
        {
            return await context.Reservas.ToListAsync();
        }

        //get 1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Reservas>> Get(int id)
        {
            Reservas? lean = await context.Reservas
                .FirstOrDefaultAsync(x => x.Id == id);

            if (lean == null)
            {
                return NotFound();
            }

            return lean;
        }

        //get 2
        [HttpGet("GetByCod/{cod}")]
        public async Task<ActionResult<Reservas>> GetByCod(string cod)
        {
            Reservas? lean = await context.Reservas
                .FirstOrDefaultAsync(x => x.MetodoPago == cod);

            if (lean == null)
            {
                return NotFound();
            }

            return lean;
        }




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await context.Reservas.AnyAsync(x => x.Id == id);
            return existe;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearReservaDTO entidadDTO)
        {
            try
            {
                //----------------------------------------------------------------------------
                //entidad que voy a adicionar a la tabla reservas en el context(Base de dato)
                //Reservas entidad = new Reservas();
                //entidad.FechaHoraReserva = entidadDTO.FechaHoraReserva;
                //entidad.DuracionAlquiler = entidadDTO.DuracionAlquiler;
                //entidad.Monto = entidadDTO.Monto;
                //entidad.MetodoPago = entidadDTO.MetodoPago;
                //entidad.EstadoReserva = entidadDTO.EstadoReserva;

                //Reemplazo de Inyeccion (En una sola linea)
                Reservas entidad = mapper.Map<Reservas>(entidadDTO);

                //---------------------------------------------------------------------------- //Comentar acá despues de hacer la inyección en el context
                context.Reservas.Add(entidad);
                await context.SaveChangesAsync(); //espera y guarda los cambios del context
                return entidad.Id; //Id de la entidad 
            }
            catch (Exception ErrorMessage)
            {
                //InnerException = quiere decir que el error vino por un tercero, en este caso por la base de datos
                return BadRequest(ErrorMessage.Message);
                //throw;
            }
        }

        [HttpPut("{id:int}")] //Api / Reservas
        public async Task<ActionResult> Put(int id, [FromBody] Reservas entidad)
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var Lean = await context.Reservas.Where(e => e.Id == id).FirstOrDefaultAsync();

            if (Lean == null)
            {
                return NotFound("No existe la reserva buscada");
            }

            Lean.FechaHoraReserva = entidad.FechaHoraReserva;
            Lean.DuracionAlquiler = entidad.DuracionAlquiler;
            Lean.Monto = entidad.Monto;
            Lean.MetodoPago = entidad.MetodoPago;
            Lean.EstadoReserva = entidad.EstadoReserva;
           

            try
            {
                context.Reservas.Update(Lean);
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
            var existe = await context.Reservas.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound($"El usuario buscado {id}, no se encuentra");
            }

            Reservas EntidadBorrar = new Reservas();
            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);

            await context.SaveChangesAsync();

            return Ok();
        }

    }
}
