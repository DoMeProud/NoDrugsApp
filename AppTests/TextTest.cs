using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoDrugs;
using Resources = NoDrugs.Properties.Resources;

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

		/// <summary>
		/// Проверка наличия сообщения со сведениями о программе.
		/// </summary>
		[TestMethod]
		public void GetAboutMessage()
		{
			Assert.IsNotNull(Resources.InfoMessage);
		}
	}
}
