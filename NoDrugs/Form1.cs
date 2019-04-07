using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoDrugs.Properties;

namespace NoDrugs
{
	/// <summary>
	/// Основная форма.
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Класс для работы с текстом.
		/// </summary>
		Text _text = new Text();

		/// <summary>
		/// Инициализация компонентов.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Метод-обработчик при загрузке формы.
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void Form1_Load(object sender, EventArgs e)
		{
			_text.LoadVocabulary();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Проверить текст".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void CheckTextBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(SourceText.Text))
			{
				MessageBox.Show("Введите текст");
				return;
			}

			if (string.IsNullOrWhiteSpace(Resources.NoDrugsVocabulary))
			{
				MessageBox.Show("Словарь не содержит слов для поиска");
				return;
			}

			if (Regex.IsMatch(SourceText.Text, @"[^0-9a-zA-ZА-Яа-я@]+"))
			{
				MessageBox.Show("Введите нормализованный текст");
				return;
			}

			_text.LoadSourceText(SourceText.Text);
			_text.CheckText(SourceText);
		}

		/// <summary>
		/// Обработка нажатия кнопки "Очистить".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void ClearBtn_Click(object sender, EventArgs e)
		{
			SourceText.Text = string.Empty;
		}

		/// <summary>
		/// Обработка нажатия кнопки "Посмотреть словарь".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void LookVocabularyMenuItem_Click(object sender, EventArgs e)
		{
			var vc = new VocabularyForm();
			vc.Show();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Сведения".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void InformationMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Resources.InfoMessage);
		}
	}
}
