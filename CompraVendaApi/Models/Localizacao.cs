using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Localizacao
    {
        [Key]
        public int localizacao_id { get; set; }

        public Nullable<int> localizacao_parent { get; set; }

        public string codigo { get; set; }

        public string titulo { get; set; }

        public string descricao { get; set; }

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool activo { get; set; }

        public bool apagado { get; set; }
    }
}
