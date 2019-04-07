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
	/// <summary>
	/// Работа с текстом.
	/// </summary>
	public class Text
	{
		/// <summary>
		/// Словарь.
		/// </summary>
		public HashSet<string> Vocabulary = new HashSet<string>();

		/// <summary>
		/// Текст для проверки.
		/// </summary>
		public HashSet<string> SourceText = new HashSet<string>();

		/// <summary>
		/// Паттерн для поиска не букв.
		/// </summary>
		private readonly string notLettersPattern = @"[^A-Za-zА-Яа-я]+";

		/// <summary>
		/// Загрузка словаря.
		/// </summary>
		public void LoadVocabulary()
		{
			Vocabulary.Clear();
			foreach (var word in Resources.NoDrugsVocabulary.Split(';'))
			{
				Vocabulary.Add(word.ToLower());
			}
		}

		/// <summary>
		/// Загрузка текста для проверки.
		/// </summary>
		/// <param name="text">Текст для проверки.</param>
		/// <returns>Успешность добавления текста на проверку.</returns>
		public bool LoadSourceText(string text)
		{
			var isLoaded = false;

			if (string.IsNullOrWhiteSpace(text))
			{
				return isLoaded;
			}

			foreach (var word in text.Split(' '))
			{
				SourceText.Add(Regex.Replace(word, notLettersPattern, string.Empty).ToLower());
				isLoaded = true;
			}

			return isLoaded;
		}

		/// <summary>
		/// Проверка текста.
		/// </summary>
		/// <param name="rtb">Текстовый блок для ввода текста.</param>
		public void CheckText(RichTextBox rtb)
		{
			if (rtb == null)
			{
				return;
			}

			var entryWords = SourceText.Intersect(Vocabulary);
			RepaintEntryWords(rtb, entryWords);
		}

		/// <summary>
		/// Окрашивание слов, которые подходят по условию.
		/// </summary>
		/// <param name="rtb">Текстовый блок для ввода текста.</param>
		/// <param name="repaintWords">Слова для окрашивания</param>
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
