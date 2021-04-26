using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    class UnionANOComma : ICommaEditor
    {
        private HashSet<string> unionWords = new HashSet<string>()
        {
            "а",
            "но",
        };
        private Sentence.Member GetFollowingDash(Sentence sentence, Sentence.Member m)
        {
            for (Sentence.Member iter = m;
                 iter != null;
                 iter = sentence.Next(iter))
            {
                if (iter.Symbols == "-" || iter.Symbols == "–")
                {
                    return iter;
                }
            }
            return null;
        }

        private Sentence.Member GetFollowingComma(Sentence sentence, Sentence.Member m)
        {
            for (Sentence.Member iter = sentence.Next(m);
                 iter != null;
                 iter = sentence.Next(iter))
            {
                if (iter.Type == Sentence.Member.MemberType.WORD)
                {
                    return null;
                }
                if (iter.Symbols != "," )
                {
                    continue;
                }
                return iter;
            }
            return null;
        }

  
        public void Edit(Sentence sentence)
        {

        }

        // Если добавляемое слово союз "а" или "но" и перед ними нет -, после последнего слова добавляем запятую, если она не была поставлена пользователем.
        public void Edit(Sentence sentence, string word)
        {
            if (!unionWords.Contains(word.ToLower()))
            {
                return;
            }

            if (sentence.NoWords())
            {
                return;
            }

            var lastWord = sentence.LastWord();

            if ((GetFollowingComma(sentence, lastWord) == null) && (GetFollowingDash(sentence, lastWord) == null))
            {
                sentence.InsertAfter(lastWord, ',');
            }
    
        }
        public void Edit(Sentence sentence, char symbol)
        {
           
        }
    }
}
