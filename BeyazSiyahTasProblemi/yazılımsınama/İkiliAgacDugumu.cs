
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımsınama
{
        public class İkiliAgacDugumu
        {
            public object veri;
            public int seviye;
            public İkiliAgacDugumu sol;
            public İkiliAgacDugumu sag;
            public İkiliAgacDugumu(object veri,int seviye)
            {
                this.seviye = seviye;
                this.veri = veri;
                sol = null;
                sag = null;
            }

        }
  }
