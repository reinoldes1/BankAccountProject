using System;

class Program
{
    static void Main()
    {
        BankAccount bankaccount1 = new BankAccount();
        bankaccount1.Accountid = 25446;
        bankaccount1.Name = "Joao Victor";
        bankaccount1.Deposit = 2500.57;
        bankaccount1.Withdraw = 50.28;
        bankaccount1.Password = "password";

        BankAccount bankaccount2 = new BankAccount();
        bankaccount2.Accountid = 24785;
        bankaccount2.Name = "Giulia";
        bankaccount2.Deposit = 15350.44;
        bankaccount2.Withdraw = 8633.05;
        bankaccount2.Password = "loveyou";

        bankaccount1.BankInformation();
        bankaccount2.BankInformation();
    }
}