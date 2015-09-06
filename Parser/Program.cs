using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParserLib;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();         

            char commanderBegin1 = '-';
            char commanderBegin2 = '/';

            string command = "";
            for(int i = 0; i < args.Length; i++)
            {
                if (args[i][0] == commanderBegin1 || args[i][0] == commanderBegin2)
                {
                    if (!string.IsNullOrEmpty(command))
                    {
                        list.Add(command);
                        command = string.Empty;
                    }

                    command = args[i];
                }
                else
                {
                    command += " " + args[i];
                }
            }
            if (!string.IsNullOrEmpty(command))
            {
                list.Add(command);
                command = string.Empty;
            }

            if (list.Count == 0)
            {
                list.Add(string.Empty);
            }

            foreach (var param in list)
            {
                var cmd = GetCommand(param);

                var res = cmd.DoAction();

                System.Console.WriteLine(res);
            }

        }


        private static ICommand GetCommand(string param)
        {
            var list = new List<ICommand>();

            list.Add(new EmptyCommand());
            list.Add(new HelpCommand());
            list.Add(new ParserCommand());
            list.Add(new PingCommand());
            list.Add(new PrintMessageCommand());

            foreach (var command in list)
            {
                command.Params = param;
                if (command.IsMatch())
                {
                    return command;
                }
            }

            return new WrongCommand();
        }
    }
}
