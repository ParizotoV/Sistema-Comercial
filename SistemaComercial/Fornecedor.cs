using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {

    public class Fornecedor {

        public int Id { get; protected set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public Fornecedor() { }

        public Fornecedor(string razaoSocial, string cnpj, string telefone, string email, Endereco endereco) {
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
        }

        public Fornecedor(int id, string razaoSocial, string cnpj, string telefone, string email, Endereco endereco) {
            Id = id;
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
        }
    }

}
