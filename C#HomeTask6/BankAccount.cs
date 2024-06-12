using MyExceptions;

namespace C_HomeTask6;

public class BankAccount
{

    public Guid AccountID { get; set; }
    public string Name { get; private set; }
    public string Password { get; set; }

    private double balance;
    private int incorrectPinAttempts;


    public double Balance
    {
        get { return balance; }

        set
        {
            if (value < 0)
            {
                throw new BalanceVerification("Balance negativ ola bilmez!");
            }
            balance = value; 
        }
    }

    public BankAccount( string name, double balance, string password)
    {
        AccountID = Guid.NewGuid();
        Name = name;
        Balance = balance;
        Password = password;
        incorrectPinAttempts = 0;
    }

    public void WithDrawMoney(double money)
    {
        if (money < 0)
        {
            throw new InputException("Daxil edilen pul menfi ola bilmez");
        }

        if (money > balance)
        {
            throw new BalanceVerification("balansda kifayet qeder mebleg yoxdur");
        }
        balance -= money;

    }

    public void DepositMoney(double money)
    {
        if (money < 0)
        {
            throw new InputException("Daxil edilen pul menfi ola bilmez");
        }
       balance += money;
    }


    public void PinChange(string NewPin)
    {

        if (string.IsNullOrEmpty(NewPin))
        {
            throw new InputException("Pin Null ola bilmez");
        }
        Password = NewPin;
    }

  
    public bool VerifyPin(string inputPin)
    {
        if (inputPin == Password)
        {
            incorrectPinAttempts = 0; 
            return true;
        }
        else
        {
            incorrectPinAttempts++;
            if (incorrectPinAttempts >= 3)
            {
                Console.WriteLine("3 defe sehv Pin Daxil etdiniz. Banka muraciyet edin.");
                Environment.Exit(0);

            }
            return false;
        }
    }



    


}
