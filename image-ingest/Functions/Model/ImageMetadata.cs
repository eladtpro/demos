namespace ImageIngest.Functions.Model;
public class ImageMetadata
{
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Modified { get; set; } = DateTime.Now;
    public string Key { get; set; }
    public ImageStatus Status { get; set; } = ImageStatus.New;
    public string Name { get; set; }
    public string Namespace { get; set; } = "default";
    public string BatchId { get; set; }
    public long Length { get; set; }
    public string Path { get; set; }

    public override string ToString() => 
        $"Name: {Name}, Namespace: {Namespace}, BatchId: {BatchId}, Key: {Key}, Length: {Length}, Created: {Created}, Modified: {Modified}";
}