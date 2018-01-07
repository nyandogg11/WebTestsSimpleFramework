using NUnit.Framework;

namespace WebTestsSimpleFramework
{
    public class GoogleSearchExampleTests : BaseTest
    {
        [Test]
        public void SearchTest()
        {
            _googleHomePage
                .ClickSearchField()
                .WriteTextInSearchField("Что делать если меня переполняет любовь к Николасу Кейджу?")
                .ClickSearchButton();
        }
    }
}
