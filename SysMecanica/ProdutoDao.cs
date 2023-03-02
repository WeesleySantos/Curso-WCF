using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysMecanica
{
    public class ProdutoDao
    {
        public static List<Produto> produtos = new List<Produto>();

        public void Adicionar(Produto p)
        {
            produtos.Add(p);
        }
        public Produto Buscar(int codigo)
        {
            var resultado = produtos.Where(x => x.codigo == codigo).First();
            return (Produto)resultado;
        }
    }
}
