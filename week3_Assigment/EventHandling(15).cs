using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Assessmentc_
{
    public class Button
    {
        // Delegate for the click event
        public delegate void ClickHandler(object sender, EventArgs e);

        // Event based on the delegate
        public event ClickHandler OnClick;

        // Method to simulate button click
        public void Click()
        {
            // Trigger the event
            OnClick?.Invoke(this, EventArgs.Empty);
        }
    }

    //public class Program15
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Create a new button instance
    //        Button button = new Button();

    //        // Subscribe to the OnClick event
    //        button.OnClick += Button_OnClick;

    //        // Simulate button click
    //        button.Click();
    //    }

    //    // Event handler method
    //    private static void Button_OnClick(object sender, EventArgs e)
    //    {
    //        Console.WriteLine("Button was clicked!");
    //    }
    //}
}
