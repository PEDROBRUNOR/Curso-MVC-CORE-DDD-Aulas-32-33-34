using AutoMapper;
using Projeto.Curso.Core.Application.Pedido.Interfaces;
using Projeto.Curso.Core.Application.Pedido.ViewModels;
using Projeto.Curso.Core.Domain.Pedido.Entidades;
using Projeto.Curso.Core.Domain.Pedido.Interfaces.Services;
using Projeto.Curso.Core.Infra.CrossCutting.Extensions;
using System;
using System.Collections.Generic;

namespace Projeto.Curso.Core.Application.Pedido.Services
{
    public class ApplicationFornecedores : IApplicationFornecedores
    {

        private readonly IServiceFornecedores serviceFornecedores;
        private readonly IMapper mapper;

        public ApplicationFornecedores(IServiceFornecedores _serviceFornecedores,
                                       IMapper _mapper )
        {
            serviceFornecedores = _serviceFornecedores;
            mapper = _mapper;
        }

        public FornecedoresViewModel Adicionar(FornecedoresViewModel fornecedor)
        {
            return mapper.Map<FornecedoresViewModel>(serviceFornecedores.Adicionar(mapper.Map<Fornecedores>(fornecedor)));
        }

        public FornecedoresViewModel Atualizar(FornecedoresViewModel fornecedor)
        {
            return mapper.Map<FornecedoresViewModel>(serviceFornecedores.Atualizar(mapper.Map<Fornecedores>(fornecedor)));
        }

        public FornecedoresViewModel Remover(FornecedoresViewModel fornecedor)
        {
            return mapper.Map<FornecedoresViewModel>(serviceFornecedores.Remover(mapper.Map<Fornecedores>(fornecedor)));
        }

        public IEnumerable<FornecedoresViewModel> ObterTodos()
        {
            return mapper.Map<IEnumerable<FornecedoresViewModel>>(serviceFornecedores.ObterTodos());
        }


        public FornecedoresViewModel ObterPorId(int id)
        {
            return mapper.Map<FornecedoresViewModel>(serviceFornecedores.ObterPorId(id));
        }

        public FornecedoresViewModel ObterPorApelido(string apelido)
        {
            return mapper.Map<FornecedoresViewModel>(serviceFornecedores.ObterPorApelido(apelido));
        }

        public FornecedoresViewModel ObterPorCpfCnpj(string cpfcnpj)
        {
            return mapper.Map<FornecedoresViewModel>(serviceFornecedores.ObterPorCpfCnpj(cpfcnpj.SomenteNumeros()));
        }

        public void Dispose()
        {
            serviceFornecedores.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
