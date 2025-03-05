using System;

namespace Assessmentc_
{
    class Person
    {
        private string? name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                age = value;
            }
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    class Studentt : Person
    {
        public required string School { get; set; }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, School: {School}";
        }
    }

    class Teacher : Person
    {
        public required string Subject { get; set; }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Subject: {Subject}";
        }
    }

    
}
