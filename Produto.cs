using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocoes { get; set; }

        public override string ToString()
        {
            return "Produto: "
                + this.Nome;
        }

        public static implicit operator int(Produto v)
        {
            throw new NotImplementedException();
        }
    }
}