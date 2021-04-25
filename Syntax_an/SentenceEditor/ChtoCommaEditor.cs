using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    class ChtoCommaEditor : ICommaEditor
    {

        // Исрпавление всего предложения
        public void Edit(Sentence sentence)
        {
            
        }

        public void Edit(Sentence sentence, char symbol)
        {

        }

        private bool HasPrecedingComma(Sentence sentence, Sentence.Member m)
        {
            for (Sentence.Member iter = sentence.Prev(m);
                 iter != null;
                 iter = sentence.Prev(iter))
            {
                if (iter.Type == Sentence.Member.MemberType.WORD)
                {
                    return false;
                }
                if (iter.Symbols != ",")
                {
                    continue;
                }
                return true;
            }
            return false;
        }

        private bool HasFollowingComma(Sentence sentence, Sentence.Member m)
        {
            for (Sentence.Member iter = sentence.Next(m);
                 iter != null;
                 iter = sentence.Next(iter))
            {
                if (iter.Type == Sentence.Member.MemberType.WORD)
                {
                    return false;
                }
                if (iter.Symbols != ",")
                {
                    continue;
                }
                return true;
            }
            return false;
        }

        // Исправление предложения перед добавлением нового слова
        public void Edit(Sentence sentence, string word)
        {
            if (word.ToLower() != "что")
            {
                return;
            }

            // Добавляемое "что" - первое слово в предложении
            if (sentence.NoWords())
            {
                return;
            }

            Sentence.Member lastMember = sentence.LastWord();
            string lastWord = lastMember.Symbols.ToLower();
            // Также надо добавить: за
            // || lastWord == "и" || lastWord == "частности" || lastWord == "именно" || lastWord == "также" || lastWord == "особенно" || lastWord == "а" || lastWord == "или"
            if (lastWord == "ни" ||
                lastWord == "не")
            {
                return;
            }
            
            if (HasFollowingComma(sentence, lastMember))
            {
                return;
            }

            sentence.InsertAfter(lastMember, ',');
        }
        
    }
}
