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
    public class ProdutoController : BaseController
    {
        public readonly IProdutoService service;

        public ProdutoController(IProdutoService service)
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
        [Route("MostrarByCodigo")]
        public async Task<ContentResult> MostrarByCodigo(string code)
        {
            var data = await service.GetByCodeAsync(code);

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpGet]
        [Route("MostrarByDescricao")]
        public async Task<ContentResult> MostrarByDescricao(string descricao)
        {
            var data = await service.GetByDescricaoAsync(descricao);

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpGet]
        [Route("MostrarByCodigoBarra")]
        public async Task<ContentResult> MostrarByCodigoBarra(string code)
        {
            var data = await service.GetByCodigoBarraAsync(code);

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }
        [HttpGet]
        [Route("MostrarFilter")]
        public async Task<ContentResult> MostrarFilter(string? codigo, string? descricao, Nullable<int> categoria_id, Nullable<int> apresentacao_id, Nullable<int> marca_id)
        {
            var data = await service.GetByFiltrosAsync(codigo, descricao, categoria_id, apresentacao_id, marca_id);

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }
        [HttpGet]
        [Route("GetProductByFilter")]
        public async Task<ContentResult> GetProductByFilter(int armazem_id, string? campo, string? valor)
        {
            var data = await service.GetProductByFilter(campo, valor, armazem_id);

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpGet]
        [Route("BundleMostrarByProductID")]
        public async Task<ContentResult> BundleMostrarByProductID(int id)
        {
            var data = await service.GetBundleMostrarByProductIDAsync(id);

            return Content(JsonConvert.SerializeObject(data), "application/json");
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar(Produto item)
        {
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                var data = await service.Save(item);

                return await FuncToCreated(data, watch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                return FormatedError<Produto>(this.GetType().Name, watch, System.Net.HttpStatusCode.ExpectationFailed, Classes.Enums.TagCode.OtherException, ex.Message);
            }
        }

        [HttpPost]
        [Route("Atualizar")]
        public async Task<IActionResult> Atualizar(Produto item)
        {
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                var data = await service.Update(item);

                return await FuncToCreated(data, watch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                return FormatedError<Produto>(this.GetType().Name, watch, System.Net.HttpStatusCode.ExpectationFailed, Classes.Enums.TagCode.OtherException, ex.Message);
            }
        }
    }
}
