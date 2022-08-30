using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace image_ingest
{
    public class QueueImageMetadata
    {
        [FunctionName("QueueImageMetadata")]
        public void Run([BlobTrigger("ingest-db/{name}", Source = BlobTriggerSource.EventGrid, Connection = "AzureWebJobsStorage")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
