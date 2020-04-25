using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {
    public class Pedido {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensProduto> ItensProdutos { get; set; }
        public DateTime DateTime { get; set; }
        public double SubTotal { get; set; }
        public double Desconto { get; set; }
        public enum FormaPagamento { Dinheiro, Debito, Credito }
        public Vendedor Vendedor { get; set; }

        public Pedido() { }

        public Pedido(Cliente cliente, List<ItensProduto> itensProdutos, DateTime dateTime, double subTotal, double desconto, Vendedor vendedor) {
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            ItensProdutos = itensProdutos ?? throw new ArgumentNullException(nameof(itensProdutos));
            DateTime = dateTime;
            SubTotal = subTotal;
            Desconto = desconto;
            Vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
        }

        public Pedido(int id, Cliente cliente, List<ItensProduto> itensProdutos, DateTime dateTime, double subTotal, double desconto, Vendedor vendedor) {
            Id = id;
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            ItensProdutos = itensProdutos ?? throw new ArgumentNullException(nameof(itensProdutos));
            DateTime = dateTime;
            SubTotal = subTotal;
            Desconto = desconto;
            Vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
        }

    }

}
