using CompraVendaApi.Data;
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
    public class CategoriaController : BaseController
    {
        public readonly ICategoriaService service;

        public CategoriaController(ICategoriaService service)
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
        
        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar(Categoria item)
        {
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                var data = await service.Save(item);

                return await FuncToCreated(data, watch.ElapsedMilliseconds);
            }
            catch(Exception ex)
            {
               return FormatedError<Categoria>(this.ToString(), watch, System.Net.HttpStatusCode.InternalServerError, Classes.Enums.TagCode.TechnicalError, ex.Message);
            }
        }
    }
}
