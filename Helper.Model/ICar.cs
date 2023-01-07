using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Model
{
    public interface ICar
    {
        string Name { get; set; }
        int Milege { get; set; }
        int Price { get; set; }

        void Ship();    
    }
}
