using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CurrencyData
    {
        #region Classes

        public class Rates
        {

        }

        public class Root
        {

            #region Private Fields

            private byte[] _timestamp;
            private string _base;
            private Rates _rates;

            #endregion

            #region Public Properties

            /// <summary>
            /// What time the rates is from
            /// </summary>
            public byte[] Timestamp
            {
                get { return _timestamp; }
                set { _timestamp = value; }
            }

            /// <summary>
            /// What base currency is used
            /// </summary>
            public string Base
            {
                get { return _base; }
                set { _base = value; }
            }

            /// <summary>
            /// The different rates
            /// </summary>
            public Rates Rates
            {
                get { return _rates; }
                set { _rates = value; }
            }

            #endregion
        }

        #endregion
    }
}
