using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoDrugs;

namespace AppTests
{
	/// <summary>
	/// Тесты класса по работе с текстом.
	/// </summary>
	[TestClass]
	public class TextTest
	{
		/// <summary>
		/// Текст.
		/// </summary>
		private NoDrugs.Text text;

		/// <summary>
		/// Инициализация перед тестами.
		/// </summary>
		[TestInitialize]
		public void PreTest()
		{
			text = new Text();
		}

		/// <summary>
		/// Тест загрузки текста.
		/// </summary>
		[TestMethod]
		public void LoadSourceTextTest()
		{
			Assert.AreEqual(true, text.LoadSourceText("test"));
		}

		/// <summary>
		/// Тест загрузки null вместо текста.
		/// </summary>
		[TestMethod]
		public void LoadNullSourceTextTest()
		{
			Assert.AreEqual(false, text.LoadSourceText(null));
		}
	}
}
