using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Marca
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int marca_id { get; set; }

        public string titulo { get; set; }

        public string? descricao { get; set; }

        public DateTime criado_data { get; set; }

        public string criado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public string atualizado_user { get; set; }

        public bool activo { get; set; } 

        public bool apagado { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
