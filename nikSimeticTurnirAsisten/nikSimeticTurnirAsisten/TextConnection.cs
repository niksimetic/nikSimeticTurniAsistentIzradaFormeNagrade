using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public class TextConnection : IDataConnection
    {
        // spoji napraviNagradu sa text files
        public NagradaModel CreatePrize(NagradaModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
