using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.WordErrors
{
    class TypoWordError : IWordError
    {
        public int Prior { get; set; }
        public string DictFileName { get; set; }

        public TypoWordError()
        {
            Prior = 1;
            DictFileName = Environment.CurrentDirectory + "\\words_ready.txt";

            LinSpell.LoadDictionary(DictFileName, "", 0, 1);
        }

        public string Correct(string word)
        {
            // TODO: возможно, стоит подбирать последний параметр в зависимости от длины слова
            // или других параметров.
            
            List<LinSpell.SuggestItem> suggestions = LinSpell.LookupLinear(word.ToLower(), "", LinSpell.editDistanceMax);
            if (suggestions.Count == 0)
            {
                return word;
            }
            char[] new_word = suggestions[0].term.ToCharArray(); 
        
            for(int i=0;i<new_word.Length && i< word.Length;i++)
            {
                if (Char.IsUpper(word[i]))
                {
                    new_word[i] = Char.ToUpper(new_word[i]);
                }
            }
            
            return String.Concat(new_word);
        }
    }
}
