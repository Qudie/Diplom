using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an
{
    interface IWordError
    {
        string Correct(string word);

        int Prior { get; set; }
    }
}
