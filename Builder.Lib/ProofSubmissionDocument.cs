using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    public class ProofSubmissionDocument : DocumentBuilder
    {
        public override void SetDocumentContent()
        {
            DocumentObject.DocumentContent = "Controls to upload files will be prepared here.";
        }

        public override void SetDocumentFooter()
        {
            DocumentObject.DocumentFooter = "Proof submission footer.";
        }

        public override void SetDocumentHeader()
        {
            DocumentObject.DocumentHeader = "Proof submission header.";
        }

        public override void SetDocumentType()
        {
            DocumentObject.DocumentType = "Proof";
        }
    }
}
