﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompraVendaApi.Models
{
    public class Armazem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int armazem_id { get; set; }

        public int loja_id { get; set; }

        public string codigo { get; set; }

        public string descricao { get; set; }

        public int ordem { get; set; }

        public bool vende { get; set; }

        public bool activo { get; set; } 

        public string criado_user { get; set; }

        public DateTime criado_data { get; set; }

        public string atualizado_user { get; set; }

        public DateTime atualizado_data { get; set; }

        public bool apagado { get; set; }

        public List<Produto_Nivel_Stock>? produto_nivel_stocks { get; set; }
        public List<Fornecedor_Encomenda?> fornecedor_encomendas { get; set; }
    }
}
