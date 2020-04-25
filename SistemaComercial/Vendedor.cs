using System;
using System.Collections.Generic;
using System.Text;

namespace br.afvs.domain {
    public class Vendedor {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Vendedor() { }

        public Vendedor(string nome, string usuario, string senha) {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
        }

        public Vendedor(int id, string nome, string usuario, string senha) {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
        }

    }

}
