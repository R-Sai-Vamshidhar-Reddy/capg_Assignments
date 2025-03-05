namespace Assessmentc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question(1)
            //int choice;
            //BankAccount account = new BankAccount();
            //decimal amount;
            //do
            //{
            //    Console.WriteLine("1. Deposit");
            //    Console.WriteLine("2. Withdraw");
            //    Console.WriteLine("3. Check Balance");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter amount to deposit: ");
            //            amount = decimal.Parse(Console.ReadLine());
            //            account.Deposit(amount);
            //            break;
            //        case 2:
            //            Console.Write("Enter amount to withdraw: ");
            //            amount = decimal.Parse(Console.ReadLine());
            //            if (account.Withdraw(amount))
            //            {
            //                Console.WriteLine("Amount withdrawn successfully");
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine("Balance: " + account.GetBalance());
            //            break;
            //        case 4:
            //            Console.WriteLine("Exiting...");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }
            //} while (choice != 4);

            //Question(2)
            //int choice;
            //List<Student> students = new List<Student>();
            //do
            //{
            //    Console.WriteLine("1. Enter Student Details");
            //    Console.WriteLine("2. Exit");
            //    Console.WriteLine("3. Display Student Details");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Student student = new Student();
            //            Console.Write("Enter student name: ");
            //            student.Name = Console.ReadLine();
            //            Console.Write("Enter student roll number: ");
            //            student.RollNo = int.Parse(Console.ReadLine());
            //            students.Add(student);
            //            break;
            //        case 2:
            //            Console.WriteLine("Exiting...");
            //            break;
            //        case 3:
            //            foreach (var s in students)
            //            {
            //                s.Display();
            //            }

            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }
            //} while (choice != 2);


            //Question(3)
            //Book defaultBook = new Book();
            //Console.WriteLine($"Default Book: Title={defaultBook.Title}, Author={defaultBook.Author}, ISBN={defaultBook.ISBN}");
            //// Create a book using the constructor with Title and Author
            //Book bookWithTitleAndAuthor = new Book("1984", "George Orwell");
            //Console.WriteLine($"Book with Title and Author: Title={bookWithTitleAndAuthor.Title}, Author={bookWithTitleAndAuthor.Author}, ISBN={bookWithTitleAndAuthor.ISBN}");
            //// Create a book using the constructor with Title, Author, and ISBN
            //Book completeBook = new Book("To Kill a Mockingbird", "Harper Lee", "978-0061120084");
            //Console.WriteLine($"Complete Book: Title={completeBook.Title}, Author={completeBook.Author}, ISBN={completeBook.ISBN}");


            //Question(4)
            //Shape circle = new Circle(5);
            //Shape rectangle = new Rectangle(4, 6);
            //Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            //Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");


            //Question(5)
            //Vehicle myCar = new Car();
            //Vehicle myBike = new Bike();
            //myCar.Start(); // Output: Car is starting with a roar.
            //myBike.Start(); // Output: Bike is starting with a vroom.


            //Question(6)
            //Person person = new Person { Name = "John Doe", Age = 30 };
            //Studentt student = new Studentt { Name = "Jane Doe", Age = 20, School = "XYZ University" };
            //Teacher teacher = new Teacher { Name = "Dr. Smith", Age = 45, Subject = "Mathematics" };
            //Person[] people = { person, student, teacher };
            //foreach (var p in people)
            //{
            //    Console.WriteLine(p.GetDetails());
            //}



            //Question(7)
            //Calculator calculator = new Calculator();
            //// Demonstrate method overloading
            //Console.WriteLine("Add two integers: " + calculator.Add(1, 2));
            //Console.WriteLine("Add three integers: " + calculator.Add(1, 2, 3));
            //Console.WriteLine("Add two doubles: " + calculator.Add(1.5, 2.5));


            //Question(8)
            //IPlayable musicPlayer = new MusicPlayer();
            //IPlayable videoPlayer = new VideoPlayer();
            //IPlayable player = new Player();
            //musicPlayer.Play();
            //videoPlayer.Play();
            //player.Play();

            //Question(9)
            //Report report = new Report
            //{
            //    Title = "Monthly Report",
            //    Content = "This is the content of the monthly report."
            //};

            //report.Print();
            //report.Save("report.txt");

            //Question(10)
            //User admin = new Admin("adminUser");
            //User customer = new Customer("customerUser");

            //admin.AccessControl();
            //customer.AccessControl();


            //Question(11)
            //ComplexNumber c1 = new ComplexNumber(1.2, 3.4);
            //ComplexNumber c2 = new ComplexNumber(5.6, 7.8);
            //ComplexNumber sum = c1 + c2;

            //Console.WriteLine($"First Complex Number: {c1}");
            //Console.WriteLine($"Second Complex Number: {c2}");
            //Console.WriteLine($"Sum: {sum}");


            //Question(12)
            //Department dept1 = new Department
            //{
            //    DepartmentName = "HR",
            //    Manager = new Manager { Name = "John Doe" }
            //};

            //// Shallow Copy
            //Department shallowCopy = dept1.ShallowCopy();
            //// Deep Copy
            //Department deepCopy = dept1.DeepCopy();

            //// Display original and copies
            //Console.WriteLine("Original: " + dept1.Manager.Name);
            //Console.WriteLine("Shallow Copy: " + shallowCopy.Manager.Name);
            //Console.WriteLine("Deep Copy: " + deepCopy.Manager.Name);

            //// Modify the manager's name in the original department
            //dept1.Manager.Name = "Jane Smith";

            //// Display after modification
            //Console.WriteLine("\nAfter modifying the original manager's name:");
            //Console.WriteLine("Original: " + dept1.Manager.Name);
            //Console.WriteLine("Shallow Copy: " + shallowCopy.Manager.Name);
            //Console.WriteLine("Deep Copy: " + deepCopy.Manager.Name);


            //Question(13)
            //Bank.SetInterestRate(0.05);
            //Bank account1 = new Bank(1000);
            //Bank account2 = new Bank(2000);
            //Console.WriteLine($"Account 1 Interest: {account1.CalculateInterest()}");
            //Console.WriteLine($"Account 2 Interest: {account2.CalculateInterest()}");
            //Bank.SetInterestRate(0.1);
            //Console.WriteLine($"Account 1 Interest after rate change: {account1.CalculateInterest()}");
            //Console.WriteLine($"Account 2 Interest after rate change: {account2.CalculateInterest()}");


            //Question(14)
            //SecuritySystem securitySystem = new SecuritySystem();
            //securitySystem.Activate();
            //securitySystem.Deactivate();


            //Question(15) in the same file


            //Question(16)
            //IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
            //vehicle1.Drive();
            //IVehicle vehicle2 = VehicleFactory.GetVehicle("bike");
            //vehicle2.Drive();


            //Question(17)
            //ILogger logger = new FileLogger();
            //logger = new TimestampLogger(logger);
            //logger = new ErrorCategorizationLogger(logger);
            //logger.Log("This is a test message.");


            //Question(18)
            //ConfigurationManager config = ConfigurationManager.Instance;

            //// Set some settings
            //config.SetSetting("AppTitle", "My Application");
            //config.SetSetting("Version", "1.0.0");

            //// Get and display settings
            //Console.WriteLine("AppTitle: " + config.GetSetting("AppTitle"));
            //Console.WriteLine("Version: " + config.GetSetting("Version"));

            //// Remove a setting
            //config.RemoveSetting("Version");

            //// Clear all settings
            //config.ClearSettings();

            //Question(19)
            //NotificationService notificationService = new NotificationService();
            //INotificationObserver emailNotifier = new EmailNotifier();
            //INotificationObserver smsNotifier = new SMSNotifier();
            //notificationService.RegisterObserver(emailNotifier);
            //notificationService.RegisterObserver(smsNotifier);
            //notificationService.NotifyObservers("This is a test notification.");
            //notificationService.UnregisterObserver(emailNotifier);
            //notificationService.NotifyObservers("This is another test notification.");


            //Question(20)
            //ShoppingCart cart = new ShoppingCart(new NoDiscount());
            //decimal total = 100m;

            //Console.WriteLine("Total with no discount: " + cart.CalculateTotal(total));

            //cart.SetDiscountStrategy(new PercentageDiscount(10));
            //Console.WriteLine("Total with 10% discount: " + cart.CalculateTotal(total));

            //cart.SetDiscountStrategy(new FixedAmountDiscount(15));
            //Console.WriteLine("Total with $15 discount: " + cart.CalculateTotal(total));


        }
    }
}
