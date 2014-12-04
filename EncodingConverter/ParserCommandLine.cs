using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingConverter
{
    public class ParserCommandLine
    {
        

        public EncodingInfo ParseToObject(String[] args) 
        {

            EncodingInfo ei = new EncodingInfo();
            
            if (args.Length == 0)
                throw new System.ArgumentException(Messages.GetEmptyCommandsError());
            
            if(args.Length == 1 && String.Equals(args[0], "-help"))
                  throw new System.ArgumentException(Messages.GetHelp());
            else if (args.Length == 8){

                for(int i = 0; i < args.Length; i++){
                    switch (args[i])
                    {
                        case "-if":
                            {
                                ei.InFile = args[++i];
                                if (!File.Exists(ei.InFile))
                                    throw new ArgumentException(Messages.GetFileNotFoundError());
                                break;
                            }
                        case "-of":
                            {
                                ei.OutFile = args[++i];
                                break;
                            }
                        case "-i":
                            {
                                ei.InEncode = args[++i];
                                break;
                            }
                        case "-o":
                            {
                                ei.OutEncode = args[++i];
                                break;
                            }
                        default:
                            throw new System.ArgumentException(Messages.GetNoFoundCommandsError());
                    } 
                  }
            }
            else 
                throw new System.ArgumentException(Messages.GetWrongNumberOfCommandsError());
            return ei;
        }

    }
}
