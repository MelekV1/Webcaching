﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDemo.Data
{
    public interface ICryptocurrencyService
    {
        Task<IEnumerable<Cryptocurrency>> GetCryptocurrencies();

    }
}
