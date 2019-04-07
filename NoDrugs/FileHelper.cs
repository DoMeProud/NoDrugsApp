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
	public static class FileHelper
	{
		public static readonly string resourcePath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources");

		public static void AddWord()
		{
			var addForm = new AddWordForm();
			addForm.Show();
		}
	}
}
