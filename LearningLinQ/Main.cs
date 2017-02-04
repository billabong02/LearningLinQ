using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLinQ
{

    class Main
    {
        private ILinQ LinQ;

        public Main(ILinQ _linq)
        {
            LinQ = _linq;
        }

        public void Execute()
        {
            LinQ.Syntax();
        }
    }
}
