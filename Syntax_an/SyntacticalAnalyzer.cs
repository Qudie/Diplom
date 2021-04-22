﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syntax_an.WordErrors;

namespace Syntax_an
{
    class SyntacticalAnalyzer
    {
        public enum AbsentCommaError
        {
            PT = 1, // Запятые в деепричастный обороте
            P = 2, // Запятые в причастном обороте
            ADDRESSING = 4, // Запятые при обращении
            INTRODUCTORY = 8, // Запятые при вводных словах
            SPP = 16, // Запятые в СПП
            SSP = 32, // Запятые в ССП
        }

        public static long DIGIT =     1;
        public static long KB_LAYOUT = 2;
        public static long TYPO =      4;

        // Чем больше число - тем выше приоритет
        public Dictionary<long, IWordError> WordErrorPrior = new Dictionary<long, IWordError>
        {
            {DIGIT,     new DigitWordError()    },
            {KB_LAYOUT, new KBLayoutWordError() },
            {TYPO,      new TypoWordError()     },
        };

        public long WordErrorMask { get; set; }
        public long AbsentCommaErrorMask { get; set; }
        public string TomitaPath { get; set; }
        public string TomitaOut { get; set; }
        public string WordSeparators = " ,!?.";
        public ISentenceSegmenter Segmenter { get; set; }

        public string Correct()
        {
            List<IWordError> errSeq = GetErrorSeq();
            string[] sentences = Segmenter.GetSentences();
            string correctText = "";

            for (int j = 0; j < sentences.Length; j++)
            {
                string sentence = sentences[j];
                string correctSentence = "";
                string word = "";

                for (int i = 0; i < sentence.Length; i++)
                {
                    char letter = sentence[i];
                    if (!WordSeparators.Contains(letter))
                    {
                        word += letter;
                    } else if (word.Length != 0)
                    {
                        word = CorrectWord(word, errSeq);
                        //TODO: место для внесения информации об изменениях в отчет
                        // Погуглить логирование. Подумать над вариантом со статическим классом
                        correctSentence += word + letter;
                        word = "";
                    } else
                    {
                        correctSentence += letter;
                    }
                }

                correctText += correctSentence;
            }

            return correctText;
        }

        private string CorrectWord(string word, List<IWordError> errSeq)
        {
            foreach (var err in errSeq)
            {
                word = err.Correct(word);
            }
            return word;
        }

        // Применяем маску ошибок в слове: составляем список из типов ошибок,
        // которые нужно исправить. Список отсортирован по убыванию приоритетов.
        private List<IWordError> GetErrorSeq()
        {
            List<IWordError> errorSeq = new List<IWordError>();
            foreach (var p in WordErrorPrior)
            {
                if ((WordErrorMask & p.Key) != 0)
                {
                    errorSeq.Add(p.Value);
                }
            }
            errorSeq.Sort((x, y) => {
                return y.Prior - x.Prior;
            });
            return errorSeq;
        }
    }
}
