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
      char[] sentenceArray = sentence.ToCharArray();
      for(int i = 0; i < sentenceArray.Length; i++)
      {
        if(sentenceArray[i]== 'e' || sentenceArray[i] == 'E')
          {
            sentenceArray[i] = '3';
          }
        else if(sentenceArray[i] == 'o' || sentenceArray[i] == 'O')
          {
            sentenceArray[i] = '0';
          }     
        else if(sentenceArray[i] == 'I')
          {
            sentenceArray[i] = '1';
          }
        else if(sentenceArray[i] == 't' || sentenceArray[i] == 'T')
          {
            sentenceArray[i] = '7';
          }  
      }
      string sentenceString = new string(sentenceArray);
      string[] inputWordArray = sentenceString.Split(" ");

      string[] convertedInput = new string[inputWordArray.Length];
      for (int j = 0; j< inputWordArray.Length; j++)
      {
        char[] tempWordArray = inputWordArray[j].ToCharArray();
        for (int i = 0; tempWordArray.Length; i++)
        {
          if (tempWordArray[i] == 's' || tempWordArray[i] == 'S')
          {
            tempWordArray[i] = 'z';
          }
        }
        string reconstructWord = new string(tempWordArray);
        convertedInput[j] = reconstructWord;
      }
      string result = string.Join(" ", convertedInput);
      return result;
    }
  }
}