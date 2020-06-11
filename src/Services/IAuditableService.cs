﻿using EventDrivenDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenDemo.Services
{
    public interface IAuditableService
    {
        event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;
    }
}
