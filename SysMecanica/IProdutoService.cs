using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SysMecanica
{
    [ServiceContract]
    public interface IProdutoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate ="AddProduto/{codigo};{descricao};{preco}")]
        bool Adicionar(string codigo, string descricao, string preco);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getProdutos/")]
        List<Produto> Produtos();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "buscarProduto/{codigo}")]
        Produto Buscar(string codigo);
    }
}
