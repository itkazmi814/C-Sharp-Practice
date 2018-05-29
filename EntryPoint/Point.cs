class User
{
  // Q: Are ; needed in C#?
  // A: Yes

  // const must be given a value on declaration
  public const int HEIGHT = 180;

  // readonly gets its value further down the line in the code
  public readonly int ID;

  
  // accessible even if the class is not instantiated yet
  public static int currentID;

  // private fields are accessible only within the class, not outside of it
  private string username;
  private int password;

  public string Username 
  { 
    get // read
    {
      return username;
    } 
  }

  public int Password 
  { 
    set
    {
      if(value >= 4 && value <= 10)
      {
        password = value;
      }
      else
      {
        System.Console.WriteLine("Not a valid passsword. Use a password between 4 and 10");
      }
    } 
  }

  public User(string username)
  {
    this.username = username;
    currentID++;
    ID = currentID;
  }
}