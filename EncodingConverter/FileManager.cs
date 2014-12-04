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
        int sizeBlock = 0;
        public Encoder() { }
        public Encoder(int sizeBlock) {
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
                        int readedSize = 0;
                        
                        while (!input.EndOfStream)
                        {
                            char[] block = new char[sizeBlock];
                            readedSize = input.Read(block, 0, sizeBlock);

                            byte[] inBytes = inEncode.GetBytes(block);
                            byte[] outBytes = Encoding.Convert(inEncode, outEncode, inBytes);
                            char[] outChars = new char[outEncode.GetCharCount(outBytes, 0, outBytes.Length)];
                            outEncode.GetChars(outBytes, 0, outBytes.Length, outChars, 0);

                            output.Write(outChars, 0, readedSize);
                        }
                    }

                }
            }
        }
    }
}
