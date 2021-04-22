using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Syntax_an
{
    public partial class Form1 : Form
    {
        private SyntacticalAnalyzer analyzer;
        private ISentenceSegmenter sentenceSegmenter;

        public Form1()
        {
            InitializeComponent();
            analyzer = new SyntacticalAnalyzer();
            sentenceSegmenter = new TomitaParser
            {
                InputFileName = Environment.CurrentDirectory + "\\tomita.input.temp",
                OutputFileName = Environment.CurrentDirectory + "\\tomita.out.temp"
            };
            analyzer.Segmenter = sentenceSegmenter;
        }

        private void SaveText_Click(object sender, EventArgs e)
        {
            try {
                var dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var outFs = File.Create(dialog.FileName);
                    using (StreamWriter sw = new StreamWriter(outFs))
                    {
                        sw.Write(CorrectedTextBox.Text);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void TypoErrorUpDown_ValueChanged(object sender, EventArgs e)
        {
            analyzer.WordErrorPrior[SyntacticalAnalyzer.TYPO].Prior = (int)(sender as NumericUpDown).Value;
        }

        private void KBLayoutErrorUpDown_ValueChanged(object sender, EventArgs e)
        {
            analyzer.WordErrorPrior[SyntacticalAnalyzer.KB_LAYOUT].Prior = (int)(sender as NumericUpDown).Value;
        }

        private void DigitErrorUpDown_ValueChanged(object sender, EventArgs e)
        {
            analyzer.WordErrorPrior[SyntacticalAnalyzer.DIGIT].Prior = (int)(sender as NumericUpDown).Value;
        }

        private void TypoErrorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;
            if (isChecked)
            {
                analyzer.WordErrorMask |= SyntacticalAnalyzer.TYPO;
            } else
            {
                analyzer.WordErrorMask &= ~SyntacticalAnalyzer.TYPO;
            }
        }

        private void KBLayoutErrorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;
            if (isChecked)
            {
                analyzer.WordErrorMask |= SyntacticalAnalyzer.KB_LAYOUT;
            }
            else
            {
                analyzer.WordErrorMask &= ~SyntacticalAnalyzer.KB_LAYOUT;
            }
        }

        private void DigitErrorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = (sender as CheckBox).Checked;
            if (isChecked)
            {
                analyzer.WordErrorMask |= SyntacticalAnalyzer.DIGIT;
            }
            else
            {
                analyzer.WordErrorMask &= ~SyntacticalAnalyzer.DIGIT;
            }
        }

        private void UploadTextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OriginalTextBox.Text = File.ReadAllText(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void CorrectTextBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(sentenceSegmenter.InputFileName, OriginalTextBox.Text);
            CorrectedTextBox.Text = analyzer.Correct();
        }
    }
}
