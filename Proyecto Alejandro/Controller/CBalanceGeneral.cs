using Proyecto_Alejandro.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alejandro.Controller
{
    public class CBalanceGeneral
    {
        public static DataTable BalanceGeneral()
        {
            return new DBalanceGeneral().BalanceGeneral();
        }
    }
}