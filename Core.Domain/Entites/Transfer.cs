﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entites
{
    public class Transfer
    {
        public Guid Id { get; set; }
        public string SourceAccountNumber {  get; set; }
        public string DestinationAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
