using System;

namespace Assessmentc_
{
    public sealed class SecuritySystem
    {
        public void Activate()
        {
            Console.WriteLine("Security System Activated.");
        }

        public void Deactivate()
        {
            Console.WriteLine("Security System Deactivated.");
        }
    }

    // The following code will cause a compile-time error because SecuritySystem is sealed and cannot be inherited.
    // public class AdvancedSecuritySystem : SecuritySystem
    // {
    // }

   
}
