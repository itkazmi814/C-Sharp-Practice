
// Lets you use a namespace
using System;
class EntryPoint
{
  static void Main()
  {
    User user = new User();

    user.Username = "abcd";
    user.Password = 5;
    Console.WriteLine(user.Username);
    Console.WriteLine(user.Password);
  } 
}
 