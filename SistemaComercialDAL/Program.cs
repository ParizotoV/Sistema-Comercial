using br.afvs.domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaComercialDAL {
    class Program {
        static void Main(string[] args) {

            Context context = new Context();

            /*

            // Novo Vendedor
            Vendedor Vendedor = new Vendedor("Felipe", "Parizoto", "123");

            // Novo Cliente
            Endereco end1 = new Endereco("83420000", "R. Santa Paulina", "149", "Praça", "Não sei", "Rio Bonito", "SC");
            Cliente cliente = new Cliente("Vinicius", "1234", "", "4321", "123", end1, "12345", "1234", "vini.o2o2o2");

            // Novo Fornecedor
            Endereco end2 = new Endereco("83420000", "R. Santa Paulina", "149", "Praça", "Não sei", "Rio Bonito", "SC");
            Fornecedor Fornecedor = new Fornecedor("Eireli ME", "1234231", "41414141", "vini.ioio", end2);

            // Novos produtos
            Produto produto0 = new Produto("Parafuso 10mm x 10mm", 10, 100, "Parafuso", Fornecedor);
            Produto produto1 = new Produto("Parafuso 12mm x 20mm", 15, 115, "Parafuso", Fornecedor);
            Produto produto2 = new Produto("Parafuso 14mm x 30mm", 20, 120, "Parafuso", Fornecedor);
            Produto produto3 = new Produto("Parafuso 16mm x 40mm", 25, 125, "Parafuso", Fornecedor);
            Produto produto4 = new Produto("Parafuso 18mm x 50mm", 30, 130, "Parafuso", Fornecedor);

            // Novos Itens para o Pedido 
            ItensProduto itensProduto0 = new ItensProduto(produto0, 2, produto0.ValorVenda);
            ItensProduto itensProduto1 = new ItensProduto(produto1, 3, produto1.ValorVenda);
            ItensProduto itensProduto2 = new ItensProduto(produto2, 5, produto2.ValorVenda);
            ItensProduto itensProduto3 = new ItensProduto(produto3, 1, produto3.ValorVenda);
            ItensProduto itensProduto4 = new ItensProduto(produto4, 9, produto4.ValorVenda);

            // Nova lista de Itens Produtos
            List<ItensProduto> listProducts = new List<ItensProduto> {
                itensProduto0,
                itensProduto1,
                itensProduto2,
                itensProduto3,
                itensProduto4
            };

            // Calculo subTotal
            double subTotal = 0;
            foreach (ItensProduto produto in listProducts) {
                subTotal += produto.ValorProduto;
            }

            // Novo pedido
            Pedido pedido = new Pedido(cliente, listProducts, new DateTime(), subTotal, 0, Vendedor);

            // Nota fiscal
            NotaFiscal notaFiscal = new NotaFiscal(1, pedido, new DateTime());

            // Adicionar no banco o vendedor
            context.Vendedores.Add(Vendedor);

            // Adicionar no banco os endereços
            context.Enderecos.Add(end1);
            context.Enderecos.Add(end2);

            // Adicionar no banco o cliente
            context.Clientes.Add(cliente);

            // Adicionar no banco o fornecedor
            context.Fornecedores.Add(Fornecedor);

            // Adicionar no banco os produtos
            context.Produtos.Add(produto0);
            context.Produtos.Add(produto1);
            context.Produtos.Add(produto2);
            context.Produtos.Add(produto3);
            context.Produtos.Add(produto4);

            // Adicionar no banco itens produtos
            context.ItensProdutos.Add(itensProduto0);
            context.ItensProdutos.Add(itensProduto1);
            context.ItensProdutos.Add(itensProduto2);
            context.ItensProdutos.Add(itensProduto3);
            context.ItensProdutos.Add(itensProduto4);

            // Adicionar no banco o pedidos
            context.Pedidos.Add(pedido);

            // Adicionar na nota fiscal
            context.NotasFiscais.Add(notaFiscal);

            context.SaveChanges();

            Console.WriteLine("Dados gravados com sucesso!");

            */

        }

    }

}
