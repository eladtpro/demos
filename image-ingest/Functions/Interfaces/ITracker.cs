namespace ImageIngest.Functions.Interfaces;
public interface ITracker
{
    void Upsert(ImageMetadata metadata);
    void UpdateAll(ActivityAction update);
    IDictionary<string, ImageMetadata> Get();
    void CLear();
}
