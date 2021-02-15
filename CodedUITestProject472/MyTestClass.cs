using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUITestProject472
{
    [TestClass]
    public class MyTestClass
    {
        [TestInitialize]
        public void TestInitialize()
        {
            if (!Playback.IsInitialized)
            {
                Playback.Initialize();
            }
        }

        [TestMethod]
        public void InputTextInBrowserPrompt()
        {
            BrowserWindow.CurrentBrowser = "IE";

            var window = BrowserWindow.Launch();

            window.ExecuteScript("prompt('Please enter your name', 'default input text');");

            window.PerformDialogAction(BrowserDialogAction.PromptText, "your name");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (Playback.IsInitialized)
            {
                Playback.Cleanup();
            }
        }
    }
}
