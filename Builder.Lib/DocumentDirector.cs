using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    public class DocumentDirector
    {
        public Document MakeDocument(DocumentBuilder documentBuilder)
        {
            documentBuilder.CreateNewDocument();
            documentBuilder.SetDocumentType();
            documentBuilder.SetDocumentHeader();
            documentBuilder.SetDocumentContent();
            documentBuilder.SetDocumentFooter();
            
            return documentBuilder.GetDocument();
        }
    }
}
