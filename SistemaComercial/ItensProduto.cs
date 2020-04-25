using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {

    public class ItensProduto {

        public int Id { get; protected set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorProduto { get; set; }

        public ItensProduto() { }

        public ItensProduto(Produto produto, int quantidade, double valorProduto) {
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
        }

        public ItensProduto(int id, Produto produto, int quantidade, double valorProduto) {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
        }
        
    }

}
