using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Syntax_an
{
    class Logger
    {
       
        public static void Write(string word, string correct_word)
        {
                using (StreamWriter sw = File.AppendText("Logs.txt"))
                {
                    sw.WriteLine(word + " -> " + correct_word);
                }
      
        }
       
        public static void EndOfLogging()
        {
            using (StreamWriter sw = File.AppendText("Logs.txt"))
            {
                sw.WriteLine("Конец работы синтаксического анализатора над текстом.");
            }
        }
    }
}
