using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using srbrettle.FinancialFormulas;

namespace Financial_System.Features
{
    class FinanceFunctions
    {
        
        public decimal CalcAssets(decimal liabilities, decimal equity)
        {
            decimal result = FinancialFormulas.CalcAssets(liabilities, equity);
            return result;
        }

        public decimal CalcEquity(decimal assets, decimal liabilities)
        {
            decimal result = FinancialFormulas.CalcEquity(assets, liabilities);
            return result;
        }

        public decimal CalcLiabilities(decimal assets, decimal equity)
        {
            decimal result = FinancialFormulas.CalcLiabilities(assets, equity);
            return result;
        }

    }
}
