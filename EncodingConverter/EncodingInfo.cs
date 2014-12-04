using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingConverter
{
    public class EncodingInfo
    {
        
        public String InFile
        {
            get;
            set;
        }
        public String OutFile
        {
            get;
            set;
        }
        public String InEncode
        {
            get;
            set;
        }
        public String OutEncode
        {
            get;
            set;
        }

        public override string ToString() 
        {
            return String.Format("Input file name: {0} in {1}\nOutput file name: {2} in {3}\n",
                InFile, InEncode, OutFile, OutEncode);
        }
    }
}
