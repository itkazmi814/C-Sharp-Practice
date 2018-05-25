class User
{
  // Q: Are ; needed in C#?
  // A: Yes

  // private fields are accessible only within the class, nto outside of it
  private string username;
  private int password;

  public string Username 
  { 
    get // read
    {
      return username;
    } 
    set // write
    {
      if(value.Length >= 4 && value.Length <= 10)
      {
        username = value;
      }
      else
      {
        System.Console.WriteLine("Not a valid username. Use a username between 4 and 10 characters");
      }
    } 
  }

  public int Password 
  { 
    get
    {
      return password;
    } 
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

  public User()
  {
    // this.username = username;
    // this.password = password;
  }
}