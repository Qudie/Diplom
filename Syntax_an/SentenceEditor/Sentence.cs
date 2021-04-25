using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.SentenceEditor
{
    class Sentence
    {
        public class Member
        {
            public enum MemberType
            {
                WORD,
                SYMBOL
            }

            public Member(int index)
            {
                Index = index;
            }

            public int Index;
            public MemberType Type { get; set; }
            public string Symbols { get; set; }
        }

        public Sentence()
        {
            sentence = new List<Member>();
        }

        public void Add(string word)
        {
            sentence.Add(new Member(sentence.Count)
            {
                Type = Member.MemberType.WORD,
                Symbols = word,
            });
        }

        public void Add(char symbol)
        {
            sentence.Add(new Member(sentence.Count)
            {
                Type = Member.MemberType.SYMBOL,
                Symbols = symbol.ToString(),
            });
        }

        public bool NoWords()
        {
            foreach (var m in sentence)
            {
                if (m.Type == Member.MemberType.WORD)
                {
                    return false;
                }
            }
            return true;
        }

        public Member LastWord()
        {
            var l = sentence.Count;
            for (int i = l - 1; i >= 0; i--)
            {
                if (sentence[i].Type == Member.MemberType.SYMBOL)
                {
                    continue;
                }
                return sentence[i];
            }
            return null;
        }

        public Member FirstWord()
        {
            foreach (var m in sentence)
            {
                if (m.Type == Member.MemberType.SYMBOL)
                {
                    continue;
                }
                return m;
            }
            return null;
        }

        public Member Find(string word)
        {
            foreach(var m in sentence)
            {
                if (m.Symbols != word)
                {
                    continue;
                }
                return m;
            }
            return null;
        }

        public string Get()
        {
            string s = "";
            foreach (var m in sentence)
            {
                s += m.Symbols;
            }
            return s;
        }

        public Member Next(Member m)
        {
            var i = m.Index;
            if (i == sentence.Count - 1)
            {
                return null;
            }
            return sentence[i + 1];
        }

        public Member Prev(Member m)
        {
            var i = m.Index;
            if (i == 0)
            {
                return null;
            }
            return sentence[i - 1];
        }

        public Member PrevWord(Member word)
        {
            for (Member iter = Prev(word); iter != null; iter = Prev(iter))
            {
                if (iter.Type != Member.MemberType.WORD)
                {
                    continue;
                }
                return iter;
            }
            return null;
        }

        public Member NextWord(Member word)
        {
            for (Member iter = Next(word); iter != null; iter = Next(iter))
            {
                if (iter.Type != Member.MemberType.WORD)
                {
                    continue;
                }
                return iter;
            }
            return null;
        }

        public void Insert(Member m, string word)
        {
            Member newM = new Member(m.Index+1)
            {
                Symbols = word,
                Type = Member.MemberType.WORD,
            };
            InsertMember(m, newM);
        }

        public void InsertAfter(Member m, char symbol)
        {
            Member newM = new Member(m.Index+1)
            {
                Symbols = symbol.ToString(),
                Type = Member.MemberType.SYMBOL,
            };
            InsertMember(m, newM);
        }

        private void InsertMember(Member m, Member newM)
        {
            for (int i = m.Index + 1; i < sentence.Count; i++)
            {
                sentence[i].Index++;
            }
            sentence.Insert(m.Index + 1, newM);
        }

        public void Remove(Member m)
        {
            for (int i = m.Index + 1; i < sentence.Count; i++)
            {
                sentence[i].Index--;
            }
            sentence.RemoveAt(m.Index);
        }

        private List<Member> sentence;
    }
}
