﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EncodingConverter
{

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ParserCommandLine pc = new ParserCommandLine();
                EncodingInfo ei = pc.ParseToObject(args);
                Console.WriteLine(ei);
                
                Encoder encoder = new Encoder(10000);
                encoder.Encode(ei);
                Console.WriteLine("done");            
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
       
    }
}
