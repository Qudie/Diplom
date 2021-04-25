using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Syntax_an.SentenceEditor
{
    class IntroductoryWordsCommaEditor : ICommaEditor
    {
        private HashSet<string> simpleWords = new HashSet<string>()
        {
            "пожалуй",
            "наверное",
            "несомненно",
            "итак",
            "следовательно",
            "впрочем",
            "например",
            "во-первых",
            "во-вторых",
            "по-моему",
            "по-твоему",
            "по-нашему",
            "по-вашему",
            "дескать",
        };

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

        // Исрпавление всего предложения
        public void Edit(Sentence sentence)
        {
            
        }

        // Исправление предложения перед добавлением нового слова
        public void Edit(Sentence sentence, string word)
        {
            if (!word.Contains(word.ToLower()))
            {
                return;
            }

            // TODO: Поставить запятую - всегда
        }

        public void Edit(Sentence sentence, char symbol)
        {
            // Удалить запятую после последнего слова, если она есть
            if (symbol != ',')
            {
                return;
            }

            var lastWord = sentence.LastWord();
            var lastComma = GetFollowingComma(sentence, lastWord);
            if (lastComma == null)
            {
                return;
            }

            sentence.Remove(lastComma);
        }
    }
}
