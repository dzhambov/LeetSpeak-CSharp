using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTests
  {

    [TestMethod]
    public void Translate_CreatInstanceOfLeetspeakTranslator_LeetspeakTranslato()
    {
      LeetspeakTranslator newSentence = new LeetspeakTranslator("sentence");
      Assert.AreEqual(typeof(LeetspeakTranslator), newSentence.GetType());
    }

    [TestMethod]
    public void Translate_SplitWordsToChar_String()
    {
      string sentence = "Epicodus";
      LeetspeakTranslator newSentence = new LeetspeakTranslator(sentence);
      string result = newSentence.Sentence;

      Assert.AreEqual(sentence, result);
    }
  }
}