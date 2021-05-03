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
            // повторяющиеся слова

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

            var v = new Sentence.MatchMember
            {
                Symbols = "в",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var c = new Sentence.MatchMember
            {
                Symbols = "с",
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

            var togo = new Sentence.MatchMember
            {
                Symbols = "того",
                Type = Sentence.MatchMember.MatchType.WORD,
            };


            // неповторяющиеся слова

            var ni = new Sentence.MatchMember
            {
                Symbols = "ни",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var chem = new Sentence.MatchMember
            {
                Symbols = "чем",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var bivalo = new Sentence.MatchMember
            {
                Symbols = "бывало",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var pochti = new Sentence.MatchMember
            {
                Symbols = "почти",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var vrode = new Sentence.MatchMember
            {
                Symbols = "вроде",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var toch_v_toch = new Sentence.MatchMember
            {
                Symbols = "точь-в-точь",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var sovsem = new Sentence.MatchMember
            {
                Symbols = "совсем",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var sovershenno = new Sentence.MatchMember
            {
                Symbols = "совершенно",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var prosto = new Sentence.MatchMember
            {
                Symbols = "просто",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var imenno = new Sentence.MatchMember
            {
                Symbols = "именно",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var tex = new Sentence.MatchMember
            {
                Symbols = "тех",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var por = new Sentence.MatchMember
            {
                Symbols = "пор",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var vremeni = new Sentence.MatchMember
            {
                Symbols = "времени",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var po = new Sentence.MatchMember
            {
                Symbols = "по",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var mere = new Sentence.MatchMember
            {
                Symbols = "мере",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var menshe = new Sentence.MatchMember
            {
                Symbols = "меньше",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var bolshe = new Sentence.MatchMember
            {
                Symbols = "больше",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var gol = new Sentence.MatchMember
            {
                Symbols = "гол",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var sokol = new Sentence.MatchMember
            {
                Symbols = "сокол",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var belka = new Sentence.MatchMember
            {
                Symbols = "белка",
                Type = Sentence.MatchMember.MatchType.WORD,
            };

            var kolese = new Sentence.MatchMember
            {
                Symbols = "колесе",
                Type = Sentence.MatchMember.MatchType.WORD,
            };


            noCommaKaks = new List<List<Sentence.MatchMember>>
            {
                // как ни в чем не бывало
                new List<Sentence.MatchMember> { kak, ni, v, chem, ne, bivalo },

                // почти как
                new List<Sentence.MatchMember> { pochti, kak },

                // вроде как
                new List<Sentence.MatchMember> { vrode, kak },

                // как можно
                new List<Sentence.MatchMember> { kak, mozno },

                // точь-в-точь как
                new List<Sentence.MatchMember> { toch_v_toch, kak },

                // не как
                new List<Sentence.MatchMember> { ne, kak },

                // совсем как
                new List<Sentence.MatchMember> { sovsem, kak },

                // совершенно как
                new List<Sentence.MatchMember> { sovershenno, kak },

                // просто как
                new List<Sentence.MatchMember> { prosto, kak },

                // именно как
                new List<Sentence.MatchMember> { imenno, kak },

                // так как
                new List<Sentence.MatchMember> { tak, kak },

                // как так
                new List<Sentence.MatchMember> { kak, tak },

                // с тех пор как
                new List<Sentence.MatchMember> { c, tex, por, kak },

                // с того времени как
                new List<Sentence.MatchMember> { c, togo, vremeni, kak},

                // по мере того как
                new List<Sentence.MatchMember> { po, mere, togo, kak },

                // как можно меньше
                new List<Sentence.MatchMember> { kak, mozno, menshe },

                // как можно больше
                new List<Sentence.MatchMember> { kak, mozno, bolshe },

                // гол как сокол
                new List<Sentence.MatchMember> { gol, kak, sokol },

                // как белка в колесе
                new List<Sentence.MatchMember> { kak, belka, v, kolese },

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
