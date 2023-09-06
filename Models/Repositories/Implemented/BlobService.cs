using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using LoveNottiesV2.Models.Repositories.Abstract;
using System.IO;
using System.Threading.Tasks;

namespace LoveNottiesV2.Models.Repositories.Implemented
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<bool> DoesBlobExists(string fileName, BlobContainer container)
        {
            var containerClient = GetContainerClient(container);
            var blobClient = containerClient.GetBlobClient(fileName);

            return await blobClient.ExistsAsync();
        }

        public async Task UploadFileBlobAsync(byte[] content, string fileName, BlobContainer container)
        {
            using (Stream stream = new MemoryStream(content))
            {
                var containerClient = GetContainerClient(container);
                var blobClient = containerClient.GetBlobClient(fileName);
                await blobClient.UploadAsync(stream);
            }
        }

        public async Task<byte[]> GetFileBlobAsync(string fileName, BlobContainer container)
        {
            var containerClient = GetContainerClient(container);
            var blobClient = containerClient.GetBlobClient(fileName);

            if (await blobClient.ExistsAsync())
            {
                var response = await blobClient.DownloadContentAsync();

                using (MemoryStream stream = new MemoryStream())
                {
                    response.Value.Content.ToStream();

                    return stream.ToArray();
                }
            }
            else
            {
                return null;
            }
        }

        private BlobContainerClient GetContainerClient(BlobContainer container)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(container.ToString());
            containerClient.CreateIfNotExists(PublicAccessType.Blob);
            return containerClient;
        }

        public async Task DeleteFromBlob(string fileName, BlobContainer container)
        {
            var containerClient = GetContainerClient(container);
            var blobClient = containerClient.GetBlobClient(fileName);
            if (await blobClient.ExistsAsync())
            {
                await blobClient.DeleteIfExistsAsync(DeleteSnapshotsOption.IncludeSnapshots);
            }
        }
    }
}
