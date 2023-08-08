using CompraVendaApi.Classes;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CompraVendaApi.Models.Shared
{
    public class WrappingModel<T> where T : class
    {
        /// <summary>
        /// Name of the controller and method
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Time { get; set; }

        [Description("Return the value of status code defined for HTTP")]
        [JsonProperty(PropertyName = "StatusCode", Required = Required.Always)]
        [EnumDataType(typeof(HttpStatusCode))]
        public int StatusCode { get; set; }


        [EnumDataType(typeof(Enums.TagCode))]
        public int? TagCode { get; set; }

        /// <summary>
        /// Application information
        /// </summary>
        public string Description { get; set; }


        public T Item { get; set; }

        public Dictionary<String, String> Error { get; set; }


        public WrappingModel()
        {
            Error = new Dictionary<String, String>();
        }
    }
}
