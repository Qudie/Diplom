using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    class IfThenCommaEditor : ICommaEditor
    {
        public void Edit(Sentence sentence, string word)
        {
            
        }

        public void Edit(Sentence sentence, char symbol)
        {
            
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
                if (iter.Symbols != ",")
                {
                    continue;
                }
                return iter;
            }
            return null;
        }

        // Расставить запятые в конструкции "если ... , то ..."
        // Ставим запятую перед последним "то" в конструкции или 
        // в предложении, если такая конструкция одна.
        // Никакие запятые не удяляются.
        public void Edit(Sentence sentence)
        {
            if (sentence.NoWords())
            {
                return;
            }

            // Последнее "то" после "если"
            Sentence.Member lastThenMember = null;
            Sentence.Member ifMember = null;

            for (Sentence.Member iter = sentence.FirstWord();
                 iter != null;
                 iter = sentence.NextWord(iter))
            {
                var word = iter.Symbols.ToLower();
                if (word == "если")
                {
                    ifMember = iter;
                    if (lastThenMember == null)
                    {
                        continue;
                    }
                    var prevThen = sentence.PrevWord(lastThenMember);
                    if (GetFollowingComma(sentence, prevThen) == null)
                    {
                        sentence.InsertAfter(prevThen, ',');
                        lastThenMember = null;
                    }
                } else if (word == "то")
                {
                    // TODO: нужно ли убирать запятые не перед последним "то"?
                    lastThenMember = iter;
                }
            }

            // Есть последнее "то", перед которым не поставлена запятая
            if (lastThenMember != null && ifMember != null)
            {
                var prevThen = sentence.PrevWord(lastThenMember);
                if (GetFollowingComma(sentence, prevThen) == null)
                {
                    sentence.InsertAfter(prevThen, ',');
                }
            }
        }
    }
}
