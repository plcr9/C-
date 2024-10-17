using System;

namespace MethodReview
{
  class Program
  {
    static string IntroducePet(string name, string petType = "cat")
    {
      string introduce = $"This is my {petType}, {name}! {name} is {age} years old!";
      return introduction;
    }

    static void Main(string[] args)
    {
      string mittensIntro = IntroducePet ("Mittens");
      Console.WriteLine(mittensIntro);

      string franklinIntro = IntroducePet ("Franklin", "turtle");
      Console.WriteLine(franklinIntro);

      string spotIntro = IntroducePet("Spot", petType: "dog");
      Console.WriteLine(spotIntro);

      string berthaIntro = IntroducePet ("Bertha", 7, "cow");
      Console.WriteLine(berthaIntro);
    }
  }
}
