using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDemo.Data
{
    public class MarketModel
    {
        public Cryptocurrency[] markets { get; set; }
        public string next { get; set; }
    }
}
