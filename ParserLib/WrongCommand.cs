using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public class WrongCommand : ICommand
    {
        public string Params
        {
            get;
            set;
        }

        public bool IsMatch()
        {
            var list = new List<ICommand>();
            list.Add(new EmptyCommand());
            list.Add(new HelpCommand());
            list.Add(new ParserCommand());
            list.Add(new PingCommand());
            list.Add(new PrintMessageCommand());

            foreach (var command in list)
            {
                command.Params = Params;
                if (command.IsMatch())
                {
                    return false;
                }
            }

            return true;
        }

        public string DoAction()
        {
            string res = Params;

            return res;
        }
    }
}
