class BankAccount
{
    public int accountid;
    public string name;
    public double balance;
    public string password;


    public void BankInformation()
    {
        Console.WriteLine($"Hello {name}, your account ID is {accountid} and your current balance is ${balance}, in case you forgot your password here it is{password}. Hope you have a nice week!\n");
    }
}