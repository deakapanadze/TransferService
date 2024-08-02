
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ShareModels;

namespace Insfrastructure
{
    public class RabbitMqProducer : IDisposable
    {
        private readonly RabbitMQ.Client.IModel _channel;

        private readonly IConnection _connection;

        public RabbitMqProducer()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "127.0.0.1:15672",
                UserName = "guest",
                Password = "guest"


            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: "transfer_queue",
                                  durable: false,
                                  exclusive: false,
                                  autoDelete: false,
                                  arguments: null);



        }


        public void SendMessage(Transfer transfer)
        {
            var message = JsonConverter.SerializeObject(transfer);
            var body = Encoding.UTF8.GetBytes(message);
            _channel.BasicPublish(Exchange: "",
                                  routingKey: "transfer_queue",
                                  BasicProperties: null,
                                 Body: body);
        }

        public void Dispose()
        {
            _channel.Close();
            _connection.Close();
        }


    }
}
