﻿namespace BotwTrainer
{
    using System;
    using System.Linq;

    public class Item
    {
        public uint Address { get; set; }

        public string AddressHex
        {
            get
            {
                return this.Address.ToString("X");
            }
        }

        public uint Value { get; set; }

        public string ValueHex
        {
            get
            {
                return this.Value.ToString("X");
            }
        }

        public uint Equipped { get; set; }

        public string EquippedHex
        {
            get
            {
                var a = BitConverter.GetBytes(this.Equipped);
                var b = (a.Reverse().First());
                var c = "-";
                if (b == 1) { 
                    c = "Equipped"; }
                return c.ToString();
            }
        }

        public uint ModType { get; set; }

        public string ModTypeHex
        {
            get
            {
                return this.ModType.ToString("X");
            }
        }

        public uint ModAmount { get; set; }

        public string ModAmountHex
        {
            get
            {
                return this.ModAmount.ToString("X");
            }
        }

        public int Page { get; set; }

        public int Unknown { get; set; }
    }
}
