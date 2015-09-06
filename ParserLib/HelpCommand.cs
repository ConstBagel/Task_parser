using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class HelpCommand : ICommand
    {
        public string Params
        {
            get;
            set; // todo: read hoiw to hide set property
        }

        public const string HelpTextVar1 = "/?";
        public const string HelpTextVar2 = "/help";
        public const string HelpTextVar3 = "-help";

        public bool IsMatch()
        {
            if (string.IsNullOrEmpty(Params))
            {
                return false;
            }

            if (   Params.ToLower() == HelpTextVar1 
                || Params.ToLower() == HelpTextVar2 
                || Params.ToLower() == HelpTextVar3)
            {
                return true;
            }

            return false;
        }

        public string DoAction()
        {
            string res = string.Empty;

            res = "This is help...";

            return res;
        }
    }
}
