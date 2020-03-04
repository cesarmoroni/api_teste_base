using System;
using System.Threading.Tasks;
using APPIO.Business.Intefaces;
using APPIO.Business.Models;
using APPIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace APPIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}