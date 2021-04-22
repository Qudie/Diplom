using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_an.WordErrors
{
    class DigitWordError : IWordError
    {
        public int Prior { get;set; }

        public DigitWordError()
        {
            Prior = 3;
        }

        public string Correct(string word)
        {         
            string correctWord = "";
            bool hasLetter = false;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                switch (letter)
                {
                    case '0':
                        correctWord += "з";
                        break;

                    case '1':
                        correctWord += "й";
                        break;

                    case '2':
                        correctWord += "ц";
                        break;

                    case '3':
                        correctWord += "у";
                        break;

                    case '4':
                        correctWord += "к";
                        break;

                    case '5':
                        correctWord += "е";
                        break;

                    case '6':
                        correctWord += "н";
                        break;

                    case '7':
                        correctWord += "г";
                        break;

                    case '8':
                        correctWord += "ш";
                        break;

                    case '9':
                        correctWord += "щ";
                        break;

                    default:
                        correctWord += letter;
                        hasLetter = true;
                        break;
                }
            }
            return (hasLetter) ? correctWord : word;
        }
    }
}
