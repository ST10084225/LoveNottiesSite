using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage;

namespace LoveNottiesV2.Models.Repositories.Abstract
{
    public enum BlobContainer
    {
        blogimages,
        successimages,
        ourpeopleimages,
        backgroundimages,
        images,
        documents,
        publiccontent
    }

    public interface IBlobService
    {
        Task UploadFileBlobAsync(byte[] content, string fileName, BlobContainer container);
        Task<byte[]> GetFileBlobAsync(string fileName, BlobContainer container);
        Task<bool> DoesBlobExists(string fileName, BlobContainer container);
        Task DeleteFromBlob(string fileName, BlobContainer container);
    }
}
