using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class PrintMessageCommand : ICommand
    {
        public string Params
        {
            get;
            set;
        }

        public const string PrintMessage = "-print";

        public bool IsMatch()
        {
            if (string.IsNullOrEmpty(Params))
            {
                return false;
            }

            if (Params.Substring(0, PrintMessage.Length).ToLower() == PrintMessage)
            {
                return true;
            }

            return false;
        }

        public string DoAction()
        {
            string res = Params.Substring(PrintMessage.Length);

            return res.Trim();
        }
    }
}
