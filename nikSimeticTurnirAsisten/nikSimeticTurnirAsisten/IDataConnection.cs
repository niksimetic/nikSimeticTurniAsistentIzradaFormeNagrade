using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public interface IDataConnection
    {
        NagradaModel CreatePrize(NagradaModel model);
        
    }
}
