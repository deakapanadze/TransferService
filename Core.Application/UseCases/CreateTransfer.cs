
using Core.Domain.Interfaces;
using Insfrastructure;
using ShareModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.UseCases
{
    public class CreateTransfer
    {
        private readonly ITransferRepository _transferRepository;
        private readonly RabbitMqProducer _rabbitMqProducer;

        public CreateTransfer (ITransferRepository transferRepository, RabbitMqProducer rabbitMqProducer)
        {
            _transferRepository = transferRepository;
            _rabbitMqProducer = rabbitMqProducer;
        }

      
        public async Task ExecuteAsync (Transfer transfer)
        {
            await _transferRepository.CreateTransferAsync(transfer);
            _rabbitMqProducer.SendMessage(transfer);
        }
    }
}
