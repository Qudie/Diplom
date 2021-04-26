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

        // После каждого вводного слова, кроме последнего, вставляем запятую, если она не была поставлена пользователем.
        public void Edit(Sentence sentence)
        {

           
            for (Sentence.Member iter = sentence.PrevWord(sentence.LastWord());
                iter != null;
                iter = sentence.PrevWord(iter))
            {
                if(simpleWords.Contains(iter.Symbols.ToLower()))
                {
                    if (GetFollowingComma(sentence, iter) != null)
                    {
                        continue;
                    }
                    sentence.InsertAfter(iter, ','); 
                }

            }


        }

        // Если добавляемое слово вводное, после последнего слова добавляем запятую, если она не была поставлена пользователем.
        public void Edit(Sentence sentence, string word)
        {
            if (!simpleWords.Contains(word.ToLower()))
            {
                return;
            }
            
            if (sentence.NoWords())
            {
                return;
            }
            
            var lastWord = sentence.LastWord();
            if (GetFollowingComma(sentence, lastWord) == null)
            {
                sentence.InsertAfter(lastWord, ',');
            }
            
        }

        public void Edit(Sentence sentence, char symbol)
        {
            
        }
    }
}
