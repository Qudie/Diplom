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
            sentence = new List<string>();
            editors = new List<ICommaEditor>
            {
                // TODO: здесь список редакторов
            };
        }

        public void Add(string word)
        {
            // TODO: вызывать анализаторы запятых
            /**
             * Что-то вроде
             * for editor in editors:
             *   editor.correct(sentence, word)
             */
            sentence.Add(word);
        }

        public void Add(char symbol)
        {
            // TODO: вызывать анализаторы запятых
            sentence.Add(symbol.ToString());
        }

        public string Get()
        {
            // TODO: если небходимо, тут можно сделать дополнительный
            // аналих всего предложения
            return String.Concat(sentence);
        }

        private List<string> sentence;
        private List<ICommaEditor> editors;
    }
}
