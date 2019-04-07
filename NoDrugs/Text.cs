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
	public class Text
	{
		public HashSet<string> Vocabulary = new HashSet<string>();
		public HashSet<string> SourceText = new HashSet<string>();
		private string notDigitsAndNumbersPattern = @"[^A-Za-zА-Яа-я]+";

		public void LoadVocabulary()
		{
			Vocabulary.Clear();
			foreach (var word in Resources.NoDrugsVocabulary.Split(';'))
			{
				Vocabulary.Add(word.ToLower());
			}
		}

		public bool LoadSourceText(string text)
		{
			var isLoaded = false;

			if (string.IsNullOrWhiteSpace(text))
			{
				return isLoaded;
			}

			foreach (var word in text.Split(' '))
			{
				SourceText.Add(Regex.Replace(word, notDigitsAndNumbersPattern, string.Empty).ToLower());
				isLoaded = true;
			}

			return isLoaded;
		}

		public void CheckText(RichTextBox rtb)
		{
			if (rtb == null)
			{
				return;
			}

			var entryWords = SourceText.Intersect(Vocabulary);
			RepaintEntryWords(rtb, entryWords);
		}

		public void RepaintEntryWords(RichTextBox rtb, IEnumerable<string> repaintWords)
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
