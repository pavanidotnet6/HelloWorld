using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace IAAI.ASAP.Repository.Data
{
    public class ASAPDataFunctions
    {
        public static ASAPSQLEntities Functions
        {
            get
            {
                return new ASAPSQLEntities();
            }
        }


    }
}
