
using C_HomeTask6;
using MyExceptions;
using System.Diagnostics;
using System.Security.Principal;

BankAccount myaccount = new BankAccount("Elshan", 2000, "123456");

while (true)
{

    Console.Write("PIN kodunu daxil edin: ");
    string pin = Console.ReadLine();

    if (myaccount.VerifyPin(pin))
    {
        Console.WriteLine("PIN doğrudu");
        break;
    }
    else
    {
        Console.WriteLine("PIN sehvdi");
    }
}

try
{
 
    // myaccount.PinChange("123");
     //myaccount.WithDrawMoney(30000);
}

catch(InputException ex)
{
    Console.WriteLine(ex.Message);
}
catch (BalanceVerification ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


