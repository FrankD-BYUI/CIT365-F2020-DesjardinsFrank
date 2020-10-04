using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Desjardins
{
    class Desk
    {
        public int Depth { get; set; }
        public int Width { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial Material { get; set; }

        public Desk(int depth, int width, int drawers, DesktopMaterial material)
        {
            this.Depth = depth;
            this.Width = width;
            this.Drawers = drawers;
            this.Material = material;
        }
    }

    enum DesktopMaterial
    {
        Oak = 1,
        Laminate = 2,
        Pine = 3,
        Rosewood = 4,
        Veneer = 5
    }
}
