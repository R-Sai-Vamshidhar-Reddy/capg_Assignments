namespace Assessment_Inheritance_
{
    sealed class SecuritySystem
    {
        public bool AuthenticateUser(string username, string password)
        {
            
            return username == "admin" && password == "password";
        }
    }


    //class AdvancedSecuritySystem : SecuritySystem
    //{
    //}
    //cannot derive from sealed class securitySystem

    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem securitySystem = new SecuritySystem();
            bool isAuthenticated = securitySystem.AuthenticateUser("admin", "password");

            if (isAuthenticated)
            {
                Console.WriteLine("User authenticated successfully.");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
        }
    }
}
