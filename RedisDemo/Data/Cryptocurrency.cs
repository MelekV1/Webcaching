using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDemo.Data
{
    public class Cryptocurrency
    {
        public string exchange_id { get; set; }

        public string symbol { get; set; }
        public string base_asset { get; set; }
        public string quote_asset { get; set; }

        public float price_unconverted { get; set; }

        public float price { get; set; }
        public double change_24h { get; set; }

        public float spread { get; set; }
        public double volume_24h { get; set; }

        public string status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }
}
