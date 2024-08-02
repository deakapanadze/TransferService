using Core.Domain.Entites;
using Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfrastructure.Implementation
{
    public class TransferRepository : ITransferRepository
    {
        private readonly DataContext _Context;

        public TransferRepository (DataContext context)
        {
            _Context = context;
        }
        public async Task CreateTransferAsync(Transfer transfer)
        {
            _Context.transfers.Add(transfer);
            await _Context.SaveChangesAsync();
        }
    }
}
