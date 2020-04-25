using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {

    public class Cliente {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Rg { get; set; }
        public string InscricaoEstadual { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Cliente() { }

        public Cliente(string nome, string cpf, string cnpj, string rg, string inscricaoEstadual, Endereco endereco, string telefone, string celular, string email) {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
            Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            Rg = rg ?? throw new ArgumentNullException(nameof(rg));
            InscricaoEstadual = inscricaoEstadual ?? throw new ArgumentNullException(nameof(inscricaoEstadual));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Celular = celular ?? throw new ArgumentNullException(nameof(celular));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public Cliente(int id, string nome, string cpf, string cnpj, string rg, string inscricaoEstadual, Endereco endereco, string telefone, string celular, string email) {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
            Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            Rg = rg ?? throw new ArgumentNullException(nameof(rg));
            InscricaoEstadual = inscricaoEstadual ?? throw new ArgumentNullException(nameof(inscricaoEstadual));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Celular = celular ?? throw new ArgumentNullException(nameof(celular));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

    }

}