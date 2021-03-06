namespace NitroxServer.Serialization.Resources.Datastructures
{
    public class AssetIdentifier
    {
        public string File { get; }
        public long IndexId { get; }

        public AssetIdentifier(string file, long indexId)
        {
            File = file;
            IndexId = indexId;
        }

        public override bool Equals(object obj)
        {
            AssetIdentifier identifier = obj as AssetIdentifier;

            return identifier != null &&
                   File == identifier.File &&
                   IndexId == identifier.IndexId;
        }

        public override int GetHashCode()
        {
            int hashCode = 390124324;

            hashCode = hashCode * -1521134295 + File.GetHashCode();
            hashCode = hashCode * -1521134295 + IndexId.GetHashCode();

            return hashCode;
        }
    }
}
