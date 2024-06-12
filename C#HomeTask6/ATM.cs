namespace C_HomeTask6;

public class ATM
{
   public Guid IdBank { get; set; }
   public string BankName { get; set; }
   
    
    public ATM(string bankName)
    {
        IdBank=Guid.NewGuid();
        BankName = bankName;
       
    }

   



}
