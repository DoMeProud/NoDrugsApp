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

namespace NoDrugs
{
	/// <summary>
	/// Форма добавления слова.
	/// </summary>
	public partial class AddWordForm : Form
	{
		/// <summary>
		/// Форма словаря.
		/// </summary>
		VocabularyForm vForm = new VocabularyForm();

		/// <summary>
		/// Инициализация компонентов формы.
		/// </summary>
		public AddWordForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Отмена".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Обработка нажатия кнопки "ОК".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Аргументы.</param>
		private void OkBtn_Click(object sender, EventArgs e)
		{
			using (var writer = new StreamWriter(Path.Combine(FileHelper.ResourcePath, "NoDrugsVocabulary.txt"), true))
			{
				writer.Write($";{WordBox.Text}");
			}

			vForm.Show();
			Close();
		}
	}
}
