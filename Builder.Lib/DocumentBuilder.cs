using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    public abstract class DocumentBuilder
    {
        protected Document DocumentObject;

        public abstract void SetDocumentType();
        public abstract void SetDocumentHeader();
        public abstract void SetDocumentContent();
        public abstract void SetDocumentFooter();

        public void CreateNewDocument()
        {
            DocumentObject = new Document();
        }
        public Document GetDocument()
        {
            return DocumentObject;
        }

    }
}
