using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBsp
{
    public interface IArbeitend
    {
        public string Job { get; set; }
        public int Gehalt { get; set; }
        void Auszahlung();
    }
}
