using System;

class Accounts
{
    int accNo;
    string custName;
    string accType;
    char transType;
    double amount;
    double balance;

    public Accounts(int accNo, string custName, string accType)
    {
        this.accNo = accNo;
        this.custName = custName;
        this.accType = accType;
        balance = 0;
    }

    public void Transaction(char tType, double amt)
    {
        transType = tType;
        amount = amt;

        if (transType == 'D')
            Credit(amount);
        else if (transType == 'W')
            Debit(amount);
        else
            Console.WriteLine("Invalid Transaction");
    }

    void Credit(double amt)
    {
        balance += amt;
    }

    void Debit(double amt)
    {
        if (amt <= balance)
            balance -= amt;
        else
            Console.WriteLine("Insufficient Balance");
    }

    public void ShowData()
    {
        Console.WriteLine($"AccNo: {accNo}, Name: {custName}, Type: {accType}, Balance: {balance}");
    }
}

class Program
{
    static void Main()
    {
        Accounts a = new Accounts(101, "Subha", "Savings");

        a.Transaction('D', 2000);
        a.Transaction('W', 300);

        a.ShowData();
    }
}