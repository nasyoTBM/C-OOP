using System;
using System.Collections.Generic;

namespace _1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Document doc = new Document("My awesome content in my awesome document!", "My little title");
            (doc as IPrintable).Print();
            doc.Title = "My new bigger title";
            IPrintable pDoc = doc;
            pDoc.Print();
            
        }
    }
}
