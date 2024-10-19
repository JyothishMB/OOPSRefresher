using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    public class AgreementDocument : DocumentBuilder
    {
        public override void SetDocumentContent()
        {
            DocumentObject.DocumentContent = "Agreement statement will be prepared here.";
        }

        public override void SetDocumentFooter()
        {
            DocumentObject.DocumentFooter = "Agreement footer.";
        }

        public override void SetDocumentHeader()
        {
            DocumentObject.DocumentHeader = "Agreement header.";
        }

        public override void SetDocumentType()
        {
            DocumentObject.DocumentType = "Agreement";
        }
    }
}
