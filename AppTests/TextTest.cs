using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoDrugs;

namespace AppTests
{
	[TestClass]
	public class TextTest
	{
		private NoDrugs.Text text;

		[TestInitialize]
		public void PreTest()
		{
			text = new Text();
		}

		[TestMethod]
		public void LoadSourceTextTest()
		{
			Assert.AreEqual(true, text.LoadSourceText("test"));
		}

		[TestMethod]
		public void LoadNullSourceTextTest()
		{
			Assert.AreEqual(false, text.LoadSourceText(null));
		}
	}
}
