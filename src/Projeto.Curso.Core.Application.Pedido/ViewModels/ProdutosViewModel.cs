using System.Collections.Generic;

namespace Projeto.Curso.Core.Application.Pedido.ViewModels
{
    public class ProdutosViewModel
    {
        public ProdutosViewModel()
        {
            ListaErros = new List<string>();
        }

        public int Id { get; set; }
        public List<string> ListaErros { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Unidade { get; set; }
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
    }
}
