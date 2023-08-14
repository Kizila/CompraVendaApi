﻿using CompraVendaApi.Data;
using CompraVendaApi.Data.Services;
using CompraVendaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace CompraVendaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmazemController : BaseController
    {
        public readonly IArmazemService service;

        public ArmazemController(IArmazemService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("MostrarTudo")]
        public async Task<ContentResult> MostrarTudo()
        {
            var data = await service.GetAllAsync();

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpGet]
        [Route("MostrarActivos")]
        public async Task<ContentResult> MostrarActivos()
        {
            var data = await service.MostrarActivos();
            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpGet]
        [Route("MostrarArmazemVendas")]
        public async Task<ContentResult> MostrarArmazemVendas()
        {
            var data = await service.MostrarVendas();
            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar(Armazem item)
        {
            Stopwatch watch = Stopwatch.StartNew();

            var data = await service.Save(item);

            return await FuncToCreated(data, watch.ElapsedMilliseconds);
        }
    }
}
