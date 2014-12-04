﻿using System;
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
            return "To use converter you should pass string in this format:\n"+
                "-i<input file code page> -o<output file code page> -if<input file name> -of<output file name>\n"+
                "You can use next parameters:\n" +
                    "-help - call help\n" +
                    "-if - set the name of input file after this key\n" +
                    "-of - set the name of result/output file after this key\n" +
                    "-i - the encoding of input file\n" +
                    "-o - the encoding of result file\n"+
                    "You can use these Encoding types:\n"+
                    "ASCII, UTF-7, UTF-8, UTF-16, UTF-32 and DBCS \n" +
                    "Please, ensure encodings have been written in right format";
        }

     
        public static String GetWrongNumberOfCommandsError()
        {
            return "Wrong number of commands\n" + GetHelp() ;
        }
        public static String GetNoFoundCommandsError() 
        {
            
            return "It is not recognized as a command\n" + GetHelp();
        }

        public static String GetEmptyCommandsError() 
        {
            return "You didn't pass any commands.\n"+GetHelp();
        }

        public static String GetFileNotFoundError()
        {
            return "You put nonexistent file or file was corrupted";
        }
    }
}
