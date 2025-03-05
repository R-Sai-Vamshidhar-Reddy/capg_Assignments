namespace Assessment_Inheritance_
{
    public class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in Account");
        }
    }

    public class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in SavingsAccount");
        }
    }

    

    //public class Program6
    //{
    //    public static void Main(string[] args)
    //    {
    //        Account account = new Account();
    //        account.CalculateInterest();

    //        SavingsAccount savingsAccount = new SavingsAccount();
    //        savingsAccount.CalculateInterest();
    //    }
    //}
}
