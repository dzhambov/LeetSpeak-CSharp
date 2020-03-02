namespace Leetspeak.Models
{
  public class LeetspeakTranslator
  {
    public string Sentence { get; }

    public LeetspeakTranslator(string sentence)
    {
      Sentence = sentence;
    }
    public string Translate(string sentence)
    {
      // char[] array = sentence.ToCharArray();
      // return new string(array);
      return sentence;
    }
  }
}