using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMecanicaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textCodigo.Text);
            String descricao = textDescricao.Text;
            String preco = textPreco.Text;
            try
            {
                ServiceReference1.ProdutoServiceClient produtoServiceClient = new ServiceReference1.ProdutoServiceClient();
                ServiceReference1.Produto produto = new ServiceReference1.Produto();
                produto.codigo = codigo;
                produto.descricao = descricao;
                produto.preco = Double.Parse(preco);
                produtoServiceClient.Adicionar(produto);
                MessageBox.Show("Produto adicionado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                textCodigo.Text = "";
                textDescricao.Text = "";
                textPreco.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textFiltro.Text);
            try
            {
                ServiceReference1.ProdutoServiceClient produtoServiceClient = new ServiceReference1.ProdutoServiceClient();
                ServiceReference1.Produto resultado = produtoServiceClient.Buscar(codigo);
                
                textCodigo.Text = resultado.codigo.ToString();
                textDescricao.Text = resultado.descricao;
                textPreco.Text = resultado.preco.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
