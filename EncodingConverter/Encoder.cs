using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncodingConverter
{
    public class Encoder
    {
        private int sizeBlock;
        public Encoder() 
        {
            this.sizeBlock = 10;
        }
        public Encoder(int sizeBlock) 
        {
            this.sizeBlock = sizeBlock;
        }
        
        public void Encode(EncodingInfo ei)
        {
            Encoding inEncode = Encoding.GetEncoding(ei.InEncode);
            Encoding outEncode = Encoding.GetEncoding(ei.OutEncode);
                                   
            using (StreamReader input = new StreamReader(ei.InFile))
            {
                using (FileStream fs = new FileStream(ei.OutFile, FileMode.Create))
                {
                    using (StreamWriter output = new StreamWriter(fs, outEncode))
                    {                       
                        while (!input.EndOfStream)
                        {
                            var data = new char[sizeBlock];
                            int amountRead = input.ReadBlock(data, 0, sizeBlock);
                            output.Write(data, 0, amountRead);
                        }
                    }

                }
            }
        }
    }
}
