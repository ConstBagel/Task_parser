using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParserLib
{
    public interface ICommand
    {
        string Params { get; set; }

        bool IsMatch();

        string DoAction();
    }
}
