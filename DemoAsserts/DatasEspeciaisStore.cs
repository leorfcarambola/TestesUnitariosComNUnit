using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts
{
    public class DatasEspeciaisStore
    {
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            if(datasEspeciais == DatasEspeciais.AnoNovo)
            {
                return new DateTime(2019, 1, 1, 0, 0, 0);
            }
            else if(datasEspeciais == DatasEspeciais.Natal)
            {
                return new DateTime(2019, 12, 25, 0, 0, 0);
            }
            else
            {
                throw new ArgumentOutOfRangeException("datasEspeciais");
            }
        }
    }
}
