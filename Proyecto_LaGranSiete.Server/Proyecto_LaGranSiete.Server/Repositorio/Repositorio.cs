﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Shared.DTO;

//namespace Proyecto_LaGranSiete.Server.Repositorio
//{
//    //classe especializada en hacer un crud sobre una tabla cualquiera de la base de datos
//    public class Repositorio<E> : where E : class, IEntityBase //(E = Entidad) 
//    {
//        private readonly Context context;

//        //constructor del repositorio
//        public Repositorio(Context context) //Inyección de dependencia (Context (Base de datosS) ) 
//        {
//            //Haciendo control + . (se crea y se asigna el campo context)

//            this.context = context;
//        }

//        public async Task<List<E>> Select() //Task == "Tarea"
//        {
//            return await context.Set<E>().ToListAsync();
//        }
//    }

   
//}
