using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    class KakCommaEditor : ICommaEditor
    {
        List<List<Sentence.MatchMember>> noCommaKaks;

        /*
         как ни в чем не бывало
         почти как
         вроде как
         как можно
         точь-в-точь как
         не как
         совсем как
         совершенно как
         просто как
         именно как
         так как
         как так
         с тех пор как
         с того времени как
         по мере того как
         как можно меньше
         как можно больше
         гол как сокол
         как белка в колесе
        */

        public KakCommaEditor()
        {
            var kak = new Sentence.MatchMember {
                Symbols = "как",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var mozno = new Sentence.MatchMember
            {
                Symbols = "можно",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var tak = new Sentence.MatchMember
            {
                Symbols = "так",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var c = new Sentence.MatchMember
            {
                Symbols = "с",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var tex = new Sentence.MatchMember
            {
                Symbols = "тех",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var togo = new Sentence.MatchMember
            {
                Symbols = "того",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var ne = new Sentence.MatchMember
            {
                Symbols = "не",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var anySymbol = new Sentence.MatchMember
            {
                Type = Sentence.MatchMember.MatchType.ANY_SYMBOL,
            };

            noCommaKaks = new List<List<Sentence.MatchMember>>
            {
                // не как
                new List<Sentence.MatchMember> { ne, kak },

                // так как
                new List<Sentence.MatchMember> { tak, kak },

                // как так
                new List<Sentence.MatchMember> { kak, tak },
            };
        }

        public void Edit(Sentence sentence, string word)
        {
            
        }

        public void Edit(Sentence sentence, char symbol)
        {
            
        }

        private Sentence.Member GetFollowingKak(Sentence sentence, Sentence.Member m)
        {
            for (Sentence.Member iter = m;
                 iter != null;
                 iter = sentence.Next(iter))
            {
                if (iter.Type == Sentence.Member.MemberType.SYMBOL)
                {
                    continue;
                }
                if (iter.Symbols.ToLower() != "как")
                {
                    continue;
                }
                return iter;
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
                if (iter.Symbols != ",")
                {
                    continue;
                }
                return iter;
            }
            return null;
        }

        public void Edit(Sentence sentence)
        {
            if (sentence.NoWords())
            {
                return;
            }

            foreach (var match in noCommaKaks)
            {
                var matchMember = sentence.GetSubsentence(match);
                if (matchMember == null)
                {
                    continue;
                }

                var kak = GetFollowingKak(sentence, matchMember);
                var prevKak = sentence.PrevWord(kak);
                if (prevKak == null)
                {
                    continue;
                }

                var comma = GetFollowingComma(sentence, prevKak);
                if (comma == null)
                {
                    continue;
                }
                sentence.Remove(comma);
            }
        }
    }
}
