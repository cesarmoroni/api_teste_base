using System;
using System.Threading.Tasks;
using APPIO.Business.Models;

namespace APPIO.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}