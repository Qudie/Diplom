using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.WordErrors
{
    class KBLayoutWordError : IWordError
    {
        public int Prior { get; set; }
        const string EngD = "qwertyuiop[]asdfghjkl;'zxcvbnm,.",
                     RuD  = "йцукенгшщзхъфывапролджэячсмитьбю",
                     EngU = "QWERTYUIOP[]ASDFGHJKL;'ZXCVBNM,.",
                     RuU  = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

        public KBLayoutWordError()
        {
            Prior = 2;
        }
        public string Correct(string word)
        {
            string correctWord = "";
            for (int i = 0; i < word.Length; i++)
            {   
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    for (int j = 0; j < EngD.Length; j++)
                    {
                        if (word[i] == EngD[j])
                        {
                            correctWord += RuD[j];
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    for (int j = 0; j < EngU.Length; j++)
                    {
                        if (word[i] == EngU[j])
                        {
                            correctWord += RuU[j];
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    correctWord += word[i];
                }
            }
                return correctWord;
        }
    }
}
