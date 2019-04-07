using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoDrugs.Properties;

namespace NoDrugs
{
	/// <summary>
	/// Статический хелпер для работы с файлами.
	/// </summary>
	public static class FileHelper
	{
		/// <summary>
		/// Путь к папке с ресурсами программы.
		/// </summary>
		public static readonly string ResourcePath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources");

		/// <summary>
		/// Открытие формы добавления строки в словарь.
		/// </summary>
		public static void AddWord()
		{
			var addForm = new AddWordForm();
			addForm.Show();
		}
	}
}
