using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    public class RegistrationDocument : DocumentBuilder
    {
        public override void SetDocumentContent()
        {
            DocumentObject.DocumentContent = "Registration form controls will be prepared here.";
        }

        public override void SetDocumentFooter()
        {
            DocumentObject.DocumentFooter = "Registration form footer.";
        }

        public override void SetDocumentHeader()
        {
            DocumentObject.DocumentHeader = "Registration form header.";
        }

        public override void SetDocumentType()
        {
            DocumentObject.DocumentType = "Registration";
        }
    }
}
