using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Desjardins
{
    class DeskQuote
    {
        public string Name { get; set; }
        public Desk Desk { get; set; }
        public int Shipping { get; set; }

        public DeskQuote(string name, Desk desk, int shipping)
        {
            Name = name;
            Desk = desk;
            Shipping = shipping;
        }
    }
}
