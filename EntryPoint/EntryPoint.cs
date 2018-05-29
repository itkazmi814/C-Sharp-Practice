
// Lets you use a namespace
using System;
class EntryPoint
{
  static void Main()
  {
    User userOne = new User("Adam");
    // Username has no setter
    // userOne.Username = "abcd";
    userOne.Password = 5;
    Console.WriteLine(userOne.Username);
    // Password has no getter
    // Console.WriteLine(userOne.Password);

    User userTwo = new User("Bob");
    User userThree = new User("Clinton");

    Console.WriteLine(userOne.ID);
    Console.WriteLine(userTwo.ID);
    Console.WriteLine(userThree.ID);
    Console.WriteLine(User.currentID);
    // Console.WriteLine(userOne.currentID);
  } 
}
 