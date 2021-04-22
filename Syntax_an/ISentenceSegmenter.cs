using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an
{
    interface ISentenceSegmenter
    {
        string InputFileName { get; set; }
        string OutputFileName { get; set; }
        string[] GetSentences();
    }
}
