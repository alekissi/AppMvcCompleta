using DevIO.Busines.Models;
using DevIO.Busines.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Busines.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);

        Task Atualizar(Fornecedor forncedor);

        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);

    }
}
