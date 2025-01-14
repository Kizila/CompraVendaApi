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
    public class FornecedorController : BaseController
    {
        public readonly IFornecedorService service;

        public FornecedorController(IFornecedorService service)
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
        [Route("GetFitrar")]
        public async Task<ContentResult> GetFitrar(string campo, string? valor)
        {
            var data = await service.GetFitrar(campo,valor ?? "");

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }
        [HttpGet]
        [Route("MostrarActivos")]
        public async Task<ContentResult> MostrarActivos()
        {
            var data = await service.MostrarActivos();
            return Content(JsonConvert.SerializeObject(data), "application/json");
        }
        
        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar(Fornecedor item)
        {
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                var data = await service.Save(item);

                return await FuncToCreated(data, watch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                return FormatedError<Fornecedor>(this.GetType().Name, watch, System.Net.HttpStatusCode.ExpectationFailed, Classes.Enums.TagCode.OtherException, ex.Message);
            }
        }

        [HttpPost]
        [Route("Atualizar")]
        public async Task<IActionResult> Atualizar(Fornecedor item)
        {
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                var data = await service.Update(item);

                return await FuncToCreated(data, watch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                return FormatedError<Fornecedor>(this.GetType().Name, watch, System.Net.HttpStatusCode.ExpectationFailed, Classes.Enums.TagCode.OtherException, ex.Message);
            }
        }
    }
}
