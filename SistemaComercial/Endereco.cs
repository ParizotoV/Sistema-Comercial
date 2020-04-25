using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {

    public class Endereco {

        public int Id { get; protected set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public Endereco() { }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf) {
            Cep = cep ?? throw new ArgumentNullException(nameof(cep));
            Logradouro = logradouro ?? throw new ArgumentNullException(nameof(logradouro));
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            Complemento = complemento ?? throw new ArgumentNullException(nameof(complemento));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Uf = uf ?? throw new ArgumentNullException(nameof(uf));
        }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf) {
            Id = id;
            Cep = cep ?? throw new ArgumentNullException(nameof(cep));
            Logradouro = logradouro ?? throw new ArgumentNullException(nameof(logradouro));
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            Complemento = complemento ?? throw new ArgumentNullException(nameof(complemento));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Uf = uf ?? throw new ArgumentNullException(nameof(uf));
        }

    }

}


