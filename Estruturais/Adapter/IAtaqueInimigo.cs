using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IAtaqueInimigo
    {
        void ArmaFogo();
        void movimenta();
        void Pilotar(string piloto);
    }
}
