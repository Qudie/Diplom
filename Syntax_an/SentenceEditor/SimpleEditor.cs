using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    class SimpleEditor
    {
        public SimpleEditor()
        {
            sentence = new Sentence();
            editors = new List<ICommaEditor>
            {
                // TODO: сделать отдельный редактор, убирающий пробелы в "во - первых" и т.д.
                new ChtoCommaEditor(),
                new IntroductoryWordsCommaEditor(),
                new UnionANOComma(),
                new IfThenCommaEditor(),
                new KakCommaEditor(),
            };
        }

        public void Add(string word)
        {
            foreach (var e in editors)
            {
                e.Edit(sentence, word);
            }
            sentence.Add(word);
        }

        public void Add(char symbol)
        {
            foreach (var e in editors)
            {
                e.Edit(sentence, symbol);
            }
            sentence.Add(symbol);
        }

        public string Get()
        {
            
            foreach (var e in editors)
            {
                e.Edit(sentence);
            }
            return sentence.Get();
        }

        private Sentence sentence;
        private List<ICommaEditor> editors;
    }
}
