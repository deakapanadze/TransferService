using Core.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Interfaces
{
    public interface ITransferRepository
    {

        Task CreateTransferAsync (Transfer transfer);
    }
}
