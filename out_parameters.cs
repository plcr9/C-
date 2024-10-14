using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string scoreAsString = "85.6";
      string statement = "Hello World";

      double scoreAsDouble;
      bool outcome;

      outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

      Console.WriteLine($"{outcome}, {scoreAsDouble}");

      string whispered = Whisper(statement, out bool marker);
      Console.WriteLine(whispered);
    }

    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
  }
}






      
