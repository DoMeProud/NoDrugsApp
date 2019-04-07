using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoDrugs.Properties;

namespace NoDrugs
{
	/// <summary>
	/// Форма словаря.
	/// </summary>
	public partial class VocabularyForm : Form
	{
		/// <summary>
		/// Инициализация компонентов.
		/// </summary>
		public VocabularyForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Метод-обработчик загрузки формы.
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void VocabularyForm_Load(object sender, EventArgs e)
		{
			LoadVocabulary();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Добавить".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void AddBtn_Click(object sender, EventArgs e)
		{
			FileHelper.AddWord();
			Close();
		}

		/// <summary>
		/// ЗЗагрузить данные словаря.
		/// </summary>
		public void LoadVocabulary()
		{
			VocabularyBox.Items.Clear();
			foreach (var word in Resources.NoDrugsVocabulary.Split(';'))
			{
				VocabularyBox.Items.Add(word);
			}
		}

		/// <summary>
		/// Обработка нажатия кнопки "Удалить".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (VocabularyBox.Text == null)
			{
				MessageBox.Show("Выберите значение из списка");
				return;
			}

			var startIndex = Resources.NoDrugsVocabulary.IndexOf(VocabularyBox.Text, StringComparison.InvariantCultureIgnoreCase);
			var endIndex = VocabularyBox.Text.Length;
			var finalVocabulary = Resources.NoDrugsVocabulary.Remove(startIndex, endIndex);
			VocabularyBox.Items.Remove(VocabularyBox.Text);
			RewriteVocabulary(finalVocabulary);

		}

		/// <summary>
		/// Переписать файл словаря.
		/// </summary>
		/// <param name="text">Текст.</param>
		private void RewriteVocabulary(string text)
		{
			using (var writer = new StreamWriter(Path.Combine(FileHelper.ResourcePath, "NoDrugsVocabulary.txt"), false, Encoding.UTF8))
			{
				writer.Write(text.Replace(";;", ";"));
			}
		}
	}
}
