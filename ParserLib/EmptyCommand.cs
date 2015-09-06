using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class EmptyCommand : ICommand
    {
        public string Params
        {
            get;
            set;
        }

        public bool IsMatch()
        {
            if (string.IsNullOrEmpty(Params))
            {
                return true;
            }

            return false;
        }

        public string DoAction()
        {
            var command = new HelpCommand();

            return command.DoAction();
        }
    }
}
