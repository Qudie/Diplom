using System;
using System.Diagnostics;
using System.IO;

namespace Syntax_an
{
    class TomitaParser : ISentenceSegmenter
    {
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; }

        private static string DictFile = Environment.CurrentDirectory + "\\mydict.gzt";
        private static string CfgFile = Environment.CurrentDirectory +  "\\tomita_config.proto";
        private static string ExeFile = Environment.CurrentDirectory +  "\\tomitaparser.exe";

        public string[] GetSentences()
        {
            CreateConfig();

            Process tomita = new Process();
            ProcessStartInfo tomitaInfo = new ProcessStartInfo();
            string cmd = "/C " + ExeFile + " " + CfgFile;

            tomitaInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            tomitaInfo.FileName = "cmd.exe";
            tomitaInfo.Arguments = cmd;
            tomita.StartInfo = tomitaInfo;
            tomita.Start();
            tomita.WaitForExit();

            return File.ReadAllLines(OutputFileName);
        }

        public void CreateConfig()
        {
            string configTxt = "encoding \"utf8\";\n" +
                               "TTextMinerConfig {\n" +
                               "  Dictionary = \"" + DictFile.Replace("\\", "\\\\") + "\";\n" +
                               "  Output = {\n" +
                               "    Format = text;\n" +
                               "    File = \"" + OutputFileName.Replace("\\", "\\\\") + "\";\n" +
                               "  }\n" +
                               "  Input = {\n" +
                               "    File = \"" + InputFileName.Replace("\\", "\\\\") + "\";\n" +
                               "  }\n" +
                               //"  PrintTree = \"tree.txt\";\n" +
                               //"  PrintRules = \"rules.txt\";\n" +
                               "}"
                               ;

            var sw = File.CreateText(CfgFile);
            sw.Write(configTxt);
            sw.Flush();
            sw.Close();
        }
    }
}
