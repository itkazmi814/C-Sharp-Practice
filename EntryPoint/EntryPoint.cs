
// Lets you use a namespace
using System;
class EntryPoint
{
  static void Main()
  {
    User user = new User();
    // Username has no setter
    // user.Username = "abcd";
    user.Password = 5;
    Console.WriteLine(user.Username);
    // Password has no getter
    // Console.WriteLine(user.Password);
  } 
}
 