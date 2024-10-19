namespace AutoCard.Stamper
{
    public interface ITarget
    {
        void StampDocument(string filePath, string stampText);
    }
}
