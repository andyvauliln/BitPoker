﻿using System;
using System.Collections.Generic;

namespace BitPoker.Models.Contracts
{
    /// <summary>
    /// The table is the concrete implementation of the contract type
    /// </summary>
	public class Table : NoLimitTexasHoldem, IPokerContract, ITable
	{
        /// <summary>
        /// Should this be an address?
        /// </summary>
        public Guid Id { get; set; }

        public String HashAlgorithm { get; set; }

        public String NetworkAddress { get; set; }

		//Probably need
		//public Int64 NLockTime { get; set; }

		//public String RedeemScript { get; private set;}

		//public String BitcoinAddress
		//{
		//	get
		//	{
		//		if (this.Peers != null)
		//		{
		//			if (this.Peers[0] != null)
		//			{
		//				return this.Peers[0].BitcoinAddress;
		//			}
		//			else
		//			{
		//				return null;
		//			}
		//		}
		//		else
		//		{
		//			return null;
		//		}
		//	}
		//}

		//public String PublicKey
		//{
		//	get
		//	{
		//		if (this.Peers != null)
		//		{
		//			if (this.Peers[0] != null)
		//			{
		//				return this.Peers[0].PublicKey;
		//			}
		//			else
		//			{
		//				return null;
		//			}
		//		}
		//		else
		//		{
		//			return null;
		//		}
		//	}
		//}

        /// <summary>
        /// Array of players in their seats
        /// </summary>
        public Peer[] Peers { get; private set; }

        public Table()
        {
            this.Id = new Guid();
            this.Peers = new Peer[10];
            this.HashAlgorithm = "SHA256";
        }

		public Table (Int16 minPlayers, Int16 maxPlayers)
		{
			this.Id = new Guid(); //duplicate?
            this.MinPlayers = minPlayers;
            this.MaxPlayers = maxPlayers;

            this.HashAlgorithm = "SHA256";
            this.Peers = new Peer[maxPlayers];
		}
	}
}