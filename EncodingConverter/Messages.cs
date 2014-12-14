using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingConverter
{
    public static class Messages
    {
        public static String GetHelp()
        {
            return "To use converter you should pass string in this format:"+Environment.NewLine+
                "-i<input file code page> -o<output file code page> -if<input file name> -of<output file name>" + Environment.NewLine +
                "You can use next parameters:" + Environment.NewLine +
                    "-help - call help" + Environment.NewLine +
                    "-if - set the name of input file after this key" + Environment.NewLine +
                    "-of - set the name of result/output file after this key" + Environment.NewLine +
                    "-i - the encoding of input file" + Environment.NewLine +
                    "-o - the encoding of result file" + Environment.NewLine +
                    "You can use these Encoding types:" + Environment.NewLine +
                    "ASCII, UTF-7, UTF-8, UTF-16, UTF-32" + Environment.NewLine +
                    "Please, ensure encodings have been written in right format";
        }

     
        public static String GetWrongNumberOfCommandsError()
        {
            return "Wrong number of commands" + Environment.NewLine + GetHelp();
        }
        public static String GetNoFoundCommandsError() 
        {

            return "It is not recognized as a command" + Environment.NewLine + GetHelp();
        }

        public static String GetEmptyCommandsError() 
        {
            return "You didn't pass any commands." + Environment.NewLine + GetHelp();
        }

        public static String GetFileNotFoundError()
        {
            return "You put nonexistent file or file was corrupted";
        }
    }
}
