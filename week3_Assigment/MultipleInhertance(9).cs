using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;

namespace Assessmentc_
{
    public interface IPrintable
    {
        void Print();
    }

    public interface ISerializable
    {
        void Save(string filePath);
    }

    public class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void Print()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, $"Title: {Title}\nContent: {Content}");
        }
    }

    
}
