using Microsoft.EntityFrameworkCore;
using br.afvs.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaComercialDAL {
    class Context : DbContext {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<ItensProduto> ItensProdutos { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;
                Database=SistemaComercial; 
                MultipleActiveResultSets=True;
                Integrated Security=True;
                Connect Timeout = 30;
                Encrypt = False;
                TrustServerCertificate = False;
                ApplicationIntent = ReadWrite;
                MultiSubnetFailover = False
                ");

        }

    }
}
