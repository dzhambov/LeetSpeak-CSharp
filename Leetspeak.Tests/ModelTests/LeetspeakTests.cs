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
    public void Translate_ReplaceEWith3_String()
    {
      string sentence = "3pic";
      LeetspeakTranslator newSentence = new LeetspeakTranslator(sentence);
      Assert.AreEqual(sentence, newSentence.Translate("Epic"));
    }

    [TestMethod]
    public void Translate_ReplaceOWith0_String()
    {
      string sentence = "0rang3";
      LeetspeakTranslator newSentence = new LeetspeakTranslator(sentence);
      Assert.AreEqual(sentence, newSentence.Translate("orange"));
    }

    [TestMethod]
    public void Translate_ReplaceIWith1_String()
    {
      string sentence = "h3ll01";
      LeetspeakTranslator newSentence = new LeetspeakTranslator(sentence);
      Assert.AreEqual(sentence, newSentence.Translate("helloI"));
    }

        [TestMethod]
    public void Translate_ReplaceTWith7_String()
    {
      string sentence = "h3ll017";
      LeetspeakTranslator newSentence = new LeetspeakTranslator(sentence);
      Assert.AreEqual(sentence, newSentence.Translate("helloIt"));
    }

    public void Translate_ReplaceNotFirstLetterSWithz_String()
    {
      string sentence = "h3ll017z";
      LeetspeakTranslator newSentence = new LeetspeakTranslator(sentence);
      Assert.AreEqual(sentence, newSentence.Translate("helloIts"));
    }
  }
}