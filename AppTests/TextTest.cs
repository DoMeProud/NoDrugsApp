using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoDrugs;

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
	}
}
