class BankAccount
{
    public int Accountid { get; set; }
    public string Name { get; set; }

    public double Withdraw { get; set; }
    public double Deposit { get; set; }

    private double balance = 0;
    public double  Balance

    {
        get
        {
            return Math.Round (balance + Deposit - Withdraw, 2);
        }
    }

    public string Password {  get; set; }


    public void BankInformation()
    {
        Console.WriteLine($"Hello {Name},\n" +
                  $"Account ID: {Accountid}\n" +
                  $"Current balance: ${Balance}\n" +
                  $"In case you forgot your password, here it is: '{Password}'.\n" +
                  "Hope you have a nice week!\n");

        Console.WriteLine($"This week you deposited ${Deposit} and withdrawn ${Withdraw},\n" +
                          $"which made your current balance ${Balance}\n");
    }
}