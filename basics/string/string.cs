using System;

namespace StringApplication {
  class Program {
    static void Main(string[] args) {
      string fname = "Rowan";
      string lname = "Atkinson";
      string fullname = fname + lname;
      Console.WriteLine("Full name: {0}", fullname);

      char[] letters = {'H', 'e', 'l', 'l', 'o'};
      string greetings = new string(letters);
      Console.WriteLine("Greetings: {0}", greetings);

      string[] sarray = { "Hello", "From", "Tutorials", "Point" };
      string message = String.Join(" ", sarray);
      Console.WriteLine("Message: {0}", message);

      DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
      string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
      Console.WriteLine("Message: {0}", chat);

      string str1 = "This is test";
      string str2 = "This is text";
      if (String.Compare(str1, str2) == 0) {
        Console.WriteLine(str1 + " and " + str2 + " are equal.");
      } else {
        Console.WriteLine(str1 + " and " + str2 + " are not equal.");
      }

      if (str1.Contains("test")) {
        Console.WriteLine("The sequence 'test' was found.");
      }

      string str3 = "Last night I dreamt of San Pedro";
      string str3_substr = str3.Substring(23);
      Console.WriteLine(str3_substr);
    }
  }
}
