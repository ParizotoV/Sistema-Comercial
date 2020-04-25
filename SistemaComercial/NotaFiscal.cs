using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {
    public class NotaFiscal {

        public int Id { get; protected set; }
        public int Codigo { get; set; }
        public Pedido Pedido { get; set; }
        public DateTime DateTime { get; set; }

        public NotaFiscal() { }

        public NotaFiscal(int codigo, Pedido pedido, DateTime dateTime) {
            Codigo = codigo;
            Pedido = pedido;
            DateTime = dateTime;
        }

        public NotaFiscal(int id, int codigo, Pedido pedido, DateTime dateTime) {
            Id = id;
            Codigo = codigo;
            Pedido = pedido ?? throw new ArgumentNullException(nameof(pedido));
            DateTime = dateTime;
        }

    }

}
