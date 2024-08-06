using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

//namespace Proyecto_LaGranSiete.Server.Repositorio
//{
//    public class Repositorio<E> : where E : class, IEntityBase
//    {
//        private readonly Context context;

//        //constructor del respositorio
//        public Repositorio(Context context)
//        {
//            this.context = context;
//        }

//        public async Task<List<E>> Select() //Task == "Tarea"
//        {
//            return await context.Set<E>().ToListAsync();
//        }

//        public async Task<int> Insert(E entidad)
//        {
//            try
//            {
//                Usuarios entidad = Mapper.Map<Usuarios>(entidad);

//                await context.Set<E>().Add(entidad);
//                await context.SaveChangesAsync(); //espera y guarda los cambios del context
//                return entidad.Id; //Id de la entidad 
//            }
//            catch (Exception Err)
//            {
//                //return BadRequest(ErrorMessage.Message);
//                throw;
//            }
//        }
//    }
//}


