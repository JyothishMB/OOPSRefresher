namespace AutoCard.Stamper
{
    public class AutoCadAdapter : ITarget
    {
        private Stamper stamper = new Stamper();
        public void StampDocument(string filePath, string stampText)
        {
            if (stampText == null)
                return;

            var signatureObject = stampText.Split("|");
            Stamp stamp = new Stamp() 
            {
                Signature = signatureObject[0],
                Name = signatureObject[1],
                Designation = signatureObject[2]
            };

            stamper.StampDrawing(filePath, stamp);
        }
    }
}
