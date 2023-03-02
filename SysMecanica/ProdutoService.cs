using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysMecanica
{
    public class ProdutoService : IProdutoService
    {
        public bool Adicionar(string codigo, string descricao, string preco)
        {
            ProdutoDao dao = new ProdutoDao();
            Produto produto = new Produto();
            produto.codigo = int.Parse(codigo);
            produto.descricao = descricao;
            produto.preco = double.Parse(preco);
            dao.Adicionar(produto);
            return true;
        }

        public Produto Buscar(string codigo)
        {
            ProdutoDao dao = new ProdutoDao();
            return dao.Buscar(int.Parse(codigo));
        }

        public List<Produto> Produtos()
        {
            return ProdutoDao.produtos;
        }
    }
}
