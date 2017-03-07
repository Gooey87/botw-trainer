namespace BotwTrainer
{
    using System;
    using System.Linq;

    public class Item
    {
        public uint NameStart { get; set; }

        public string Name { get; set; }

        public string Defined_Name
        {
            get
            {
                var a = (this.Name);
                var b = "-";
                if (a == "BombArrow A")
                {
                    b = "Bomb Arrow";
                }
                else if (a == "ElectricArrow")
                {
                    b = "Shock Arrow";
                }
                else if (a == "FireArrow")
                {
                    b = "Fire Arrow";
                }
                else if (a == "NormalArrow")
                {
                    b = "Arrow";
                }
                else if (a == "Weapon Lsword 060")
                {
                    b = "Fierce Deity Sword";
                }
                else if (a == "Armor 229 Upper")
                {
                    b = "Fierce Deity Armor";
                }
                else if (a == "Armor 229 Lower")
                {
                    b = "Fierce Deity Boots";
                }
                else if (a == "Armor 229 Head")
                {
                    b = "Fierce Deity Mask";
                }
                else b = a;
                return b.ToString();
            }
        }

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
                if (b == 1)
                {
                    c = "Equipped";
                }
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
