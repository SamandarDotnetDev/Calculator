using System;
namespace CALCULATOR.Classes
{
  class Security
  {
    private string password;
    public  void security()
    {
      do
      {
        System.Console.WriteLine("Parolni Kiriting");
        password=Convert.ToString(Console.ReadLine());                
      } while (password!="p@$$w0rd");
    }
  }
}