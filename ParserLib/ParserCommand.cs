using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class ParserCommand : ICommand
    {
        public string Params
        {
            get;
            set;
        }

        public const string ParserTextVar3 = "-k";

        public bool IsMatch()
        {
            if (string.IsNullOrEmpty(Params))
            {
                return false;
            }

            if (    Params.Length > ParserTextVar3.Length 
                 && Params.Substring(0, ParserTextVar3.Length).ToLower() == ParserTextVar3)
            {
                return true;
            }

            return false;
        }

        private string PrintFormat = "{0}-{1}";

        public string DoAction()
        {                       
            StringBuilder sb = new StringBuilder();
            
            var val = Params.Substring(ParserTextVar3.Length);

            val = val.Trim();
            string[] data = val.Split(' ');

            for (int i = 0; i < data.Length; i = i + 2)
            {
                sb.AppendLine(string.Format(PrintFormat, 
                    data[i],
                    i + 1 < data.Length ? data[i + 1] : "<null>"));
            }

            return sb.ToString().Trim();
        }
    }
}
