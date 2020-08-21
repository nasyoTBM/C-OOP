using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    public class Document : Tefter ,IPrintable
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public Document(string content, string title)
        {
            Title = title;
            Content = content;
        }
        public void Print()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Content);
        }

        public override void Edit()
        {
           
        }
    }
}
