namespace ImageIngest.Functions;
public class ProcessIncomingImageBlob
{
    [FunctionName("ProcessIncomingImageBlob")]
    public async Task Run(
        [BlobTrigger("ingest-db/{name}", Source = BlobTriggerSource.EventGrid, Connection = "AzureWebJobsStorage")]
            Stream blob, string name,
        [DurableClient] IDurableEntityClient entityClient,
        ILogger log)
    {
        log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {blob.Length} Bytes");

        ImageMetadata md = new ImageMetadata
        {
            id = name.Sanitize(),
            //@namespace = name.BatchId(), 
            status = ImageStatus.Stored,
            length = blob.Length,
            path = name,
            name = name
        };

        log.LogInformation($"Original blob name: {name}  details: {md}");

        // The "Tracker/{namespace}" entity is created on-demand.
        EntityId entityId = new EntityId("Tracker", md.@namespace);
        await entityClient.SignalEntityAsync(entityId, "add", md);
    }
}
