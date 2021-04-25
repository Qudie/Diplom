using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    interface ICommaEditor
    {
        void Edit(Sentence sentence, string word);

        void Edit(Sentence sentence, char symbol);

        void Edit(Sentence sentence);
    }
}
