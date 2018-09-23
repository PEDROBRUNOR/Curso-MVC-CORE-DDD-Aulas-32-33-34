using AutoMapper;
using Projeto.Curso.Core.Application.Pedido.Interfaces;
using Projeto.Curso.Core.Application.Pedido.ViewModels;
using Projeto.Curso.Core.Domain.Pedido.Entidades;
using Projeto.Curso.Core.Domain.Pedido.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Projeto.Curso.Core.Application.Pedido.Services
{
    public class ApplicationProdutos : IApplicationProdutos
    {
        private readonly IServiceProdutos serviceProdutos;
        private readonly IMapper mapper;

        public ApplicationProdutos(IServiceProdutos _serviceProdutos,
                                   IMapper _mapper )
        {
            serviceProdutos = _serviceProdutos;
            mapper = _mapper;
        }


        public ProdutosViewModel Adicionar(ProdutosViewModel produto)
        {
            return mapper.Map<ProdutosViewModel>(serviceProdutos.Adicionar(mapper.Map<Produtos>(produto)));
        }

        public ProdutosViewModel Atualizar(ProdutosViewModel produto)
        {
            return mapper.Map<ProdutosViewModel>(serviceProdutos.Atualizar(mapper.Map<Produtos>(produto)));
        }

        public ProdutosViewModel Remover(ProdutosViewModel produto)
        {
            return mapper.Map<ProdutosViewModel>(serviceProdutos.Remover(mapper.Map<Produtos>(produto)));
        }

        public IEnumerable<ProdutosViewModel> ObterTodos()
        {
            return mapper.Map<IEnumerable<ProdutosViewModel>>(serviceProdutos.ObterTodos());
        }

        public ProdutosViewModel ObterPorId(int id)
        {
            return mapper.Map<ProdutosViewModel>(serviceProdutos.ObterPorId(id));
        }

        public ProdutosViewModel ObterPorApelido(string apelido)
        {
            return mapper.Map<ProdutosViewModel>(serviceProdutos.ObterPorApelido(apelido));
        }


        public ProdutosViewModel ObterPorNome(string nome)
        {
            return mapper.Map<ProdutosViewModel>(serviceProdutos.ObterPorNome(nome));
        }



        public void Dispose()
        {
            serviceProdutos.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
