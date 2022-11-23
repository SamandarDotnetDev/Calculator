namespace CALCULATOR.Classes
{
  class Security
  {
    public string password ;
    private  void security(string password)
    {
      do
      {
        System.Console.WriteLine("Parolni Kiriting");
        password=Convert.ToString(Console.ReadLine());                
      } while (password=="p@$$w0rd");
    }
  }
}