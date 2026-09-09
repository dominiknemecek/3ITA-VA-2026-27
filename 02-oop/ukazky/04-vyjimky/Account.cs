public class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            // "throw" okamžitě přeruší běh metody a předá výjimku volajícímu
            // kódu — dál se nevykoná ani řádek Balance -= amount.
            throw new InsufficientFundsException(amount, Balance);
        }

        Balance -= amount;
    }
}
