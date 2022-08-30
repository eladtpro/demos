
using System.IO.Compression;
using Azure.Storage.Blobs;
using System.IO.Packaging;

namespace ImageIngest.Functions;
public static class Zipper
{

    [FunctionName("Zipper")]
    public static string Run(
        [ActivityTrigger] ActivityAction activity,
        [Blob("ingest-db/{name}", Connection = "AzureWebJobsStorage")] BlobClient blobClient,
        [DurableClient] IDurableEntityClient client,
        ILogger log)
    {
        
        //        await blobClient.DownloadStreamingAsync() .UploadAsync() .UploadFromStreamAsync(fileStream);


        ZipArchive archive = new ZipArchive(sbyte, ZipArchiveMode.Create, false);


        return $"Hello {name}!";
    }

    private static void AddFileToZip(string zipFilename, string fileToAdd, CompressionOption compression = CompressionOption.Normal)
    {
        using (Package zip = System.IO.Packaging.Package.Open(zipFilename, FileMode.OpenOrCreate))
        {
            string destFilename = ".\\" + Path.GetFileName(fileToAdd);
            Uri uri = PackUriHelper.CreatePartUri(new Uri(destFilename, UriKind.Relative));
            if (zip.PartExists(uri))
            {
                zip.DeletePart(uri);
            }
            PackagePart part = zip.CreatePart(uri, "", compression);
            using (FileStream fileStream = new FileStream(fileToAdd, FileMode.Open, FileAccess.Read))
            {
                using (Stream dest = part.GetStream())
                {
                    fileStream.CopyTo(dest);
                }
            }
        }
    }

}

