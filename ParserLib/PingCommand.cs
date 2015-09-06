using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class PingCommand : ICommand
    {
        public string Params
        {
            get;
            set;
        }


        public const string PingText = "-ping";

        public bool IsMatch()
        {
            if (string.IsNullOrEmpty(Params))
            {
                return false;
            }

            if (Params.ToLower() == PingText)
            {
                return true;
            }

            return false;
        }

        public string DoAction()
        {
            Console.Beep();
            string res = "ping...";

            //todo: find solution 

            return res;
        }
    }
}
