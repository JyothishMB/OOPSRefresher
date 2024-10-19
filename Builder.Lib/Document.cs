namespace Builder.Lib
{
    public class Document
    {
        public string DocumentType { get; set; }
        public string DocumentHeader { get; set; }
        public string DocumentFooter { get; set; }
        public string DocumentContent { get; set; }

        public void DisplayDocument()
        {
            Console.WriteLine("Document Type :" + DocumentType);
            Console.WriteLine("Header :" + DocumentHeader);
            Console.WriteLine("Content :" + DocumentContent);
            Console.WriteLine("Footer :" + DocumentFooter);
        }
    }
}
