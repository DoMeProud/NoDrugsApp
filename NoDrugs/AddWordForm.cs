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
	public partial class AddWordForm : Form
	{
		VocabularyForm vForm = new VocabularyForm();

		public AddWordForm()
		{
			InitializeComponent();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			using (var writer = new StreamWriter(Path.Combine(FileHelper.resourcePath, "NoDrugsVocabulary.txt"), true))
			{
				writer.Write($";{WordBox.Text}");
			}

			vForm.Show();
			Close();
		}
	}
}
