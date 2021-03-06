﻿using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels.RoomService;
using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ParticipanteController : ControllerBase
    {
        private readonly DataContext context;

        public ParticipanteController(DataContext context)
        {
            this.context = context;
        }

        //GET api/Participante
        //Retorna la lista de participanes de la sala

        [Route("GetList")]
        [HttpGet]
        public ActionResult<IEnumerable<Participante>> Get()
        {
            return context.Participantes.ToList();

        }

        [Route("PostCliente")]
        [HttpPost]
        public string Post(Cliente cliente)
        {

            cliente.DateCreated = DateTime.Now;
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return "Ok";

        }
        [Route("AddPropietario")]
        [HttpPost]
        public void AgregarPropietarioASala(int IdCliente, int IdSala, Roles rol)
        {
        }

        [Route("AddParticipante")]
        [HttpPost]
        public async void AgregarParticipanteASala(ParticipanteRequest entrada)
        {

            Sala sala = context.Salas.FirstOrDefault(x => x.Id == entrada.IdSala);
            Participante participante = context.Participantes.FirstOrDefault(x => x.Cliente.IdentityUsuario.Email == entrada.Correo);



            if (participante == null)
            {
                ConsultarAPI consultarAPI = new ConsultarAPI();
                Cliente cliente = await consultarAPI.GetClienteAsync("epolicardo@bancor.com.ar");

                participante = new Participante
                {
                    Rol = entrada.rol,
                    Cliente = cliente,
                    FechaAlta = DateTime.Now,
                    Token = Guid.NewGuid().ToString()
                };
                context.Participantes.Add(participante);
            }

            if (sala == null)
                NotFound();
            else
            {
                SalaParticipante salaUser = new SalaParticipante
                {
                    Participante = participante,
                    Sala = sala
                };

                context.SalaParticipante.Add(salaUser);
                context.SaveChanges();
            }

        }


    }

    public class ParticipanteRequest
    {
        public string Correo { get; set; }
        public int IdSala { get; set; }
        public Roles rol { get; set; }
    }
}