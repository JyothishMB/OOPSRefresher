namespace AutoCard.Stamper
{
    public class Stamp
    {
        public Stamp() 
        {
            StampDate = DateTime.Now;
        }
        public string Signature { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime StampDate { get; set; }
    }
}
