using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoDrugs.Properties;

namespace NoDrugs
{
	internal class Text
	{
		internal HashSet<string> vocabulary = new HashSet<string>();
		internal HashSet<string> sourceText = new HashSet<string>();
		private string notDigitsAndNumbersPattern = @"[^A-Za-zА-Яа-я]+";

		internal void LoadVocabulary()
		{
			vocabulary.Clear();
			foreach (var word in Resources.NoDrugsVocabulary.Split(';'))
			{
				vocabulary.Add(word.ToLower());
			}
		}

		internal void LoadSourceText(string text)
		{
			foreach (var word in text.Split(' '))
			{
				sourceText.Add(Regex.Replace(word, notDigitsAndNumbersPattern, string.Empty).ToLower());
			}
		}

		internal void CheckText(RichTextBox rtb)
		{
			if (rtb == null)
			{
				return;
			}

			var entryWords = sourceText.Intersect(vocabulary);
			RepaintEntryWords(rtb, entryWords);
		}

		internal void RepaintEntryWords(RichTextBox rtb, IEnumerable<string> repaintWords)
		{
			if (rtb == null || repaintWords == null)
			{
				return;
			}

			rtb.SelectAll();
			rtb.SelectionColor = Color.Black;

			foreach (var repaintWord in repaintWords)
			{
				var regex = new Regex(repaintWord, RegexOptions.IgnoreCase);
				var matches = regex.Matches(rtb.Text);

				foreach (Match match in matches)
				{
					rtb.Select(match.Index, match.Length);
					rtb.SelectionColor = Color.Red;
				}
			}

			
		}

	}
}
