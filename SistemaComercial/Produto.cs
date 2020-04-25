using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {

    public class Produto {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public string Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Produto() { }

        public Produto(string nome, double valorCompra, double valorVenda, string categoria, Fornecedor fornecedor) {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
            Fornecedor = fornecedor ?? throw new ArgumentNullException(nameof(fornecedor));
        }

        public Produto(int id, string nome, double valorCompra, double valorVenda, string categoria, Fornecedor fornecedor) {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
            Fornecedor = fornecedor ?? throw new ArgumentNullException(nameof(fornecedor));
        }

    }

}
