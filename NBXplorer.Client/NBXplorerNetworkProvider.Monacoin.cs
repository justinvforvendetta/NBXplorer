﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitMonacoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Monacoin.Instance, networkType)
			{
				MinRPCVersion = 140200,
				CoinType = networkType == NetworkType.Mainnet ? new KeyPath("22'") : new KeyPath("1'")
			});
		}

		public NBXplorerNetwork GetMONA()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Monacoin.Instance.CryptoCode);
		}
	}
}
