﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoinbaseExchange.NET.Core
{
    public abstract class ExchangeResponseBase
    {
		public string Message { get; set; }

		private ExchangeResponseBase() { }

        protected ExchangeResponseBase(ExchangeResponse response) { }
    }
}
