using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoDrugs;
using Resources = NoDrugs.Properties.Resources;

namespace AppTests
{
	/// <summary>
	/// ����� ������ �� ������ � �������.
	/// </summary>
	[TestClass]
	public class TextTest
	{
		/// <summary>
		/// �����.
		/// </summary>
		private NoDrugs.Text text;

		/// <summary>
		/// ������������� ����� �������.
		/// </summary>
		[TestInitialize]
		public void PreTest()
		{
			text = new Text();
		}

		/// <summary>
		/// ���� �������� ������.
		/// </summary>
		[TestMethod]
		public void LoadSourceTextTest()
		{
			Assert.AreEqual(true, text.LoadSourceText("test"));
		}

		/// <summary>
		/// ���� �������� null ������ ������.
		/// </summary>
		[TestMethod]
		public void LoadNullSourceTextTest()
		{
			Assert.AreEqual(false, text.LoadSourceText(null));
		}

		/// <summary>
		/// �������� ������� ��������� �� ���������� � ���������.
		/// </summary>
		[TestMethod]
		public void GetAboutMessage()
		{
			Assert.IsNotNull(Resources.InfoMessage);
		}
	}
}
