using System;

namespace NEWCALCULATR.Classes
{
  public class Security
  {

    public void InputPassword()
    {
      string pasword = "";
        do
        {
          System.Console.Write("Enter password: ");
          pasword=Console.ReadLine();
        }while(pasword!="123");
    }

  }
}