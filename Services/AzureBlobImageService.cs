using CloudSoft2.Configurations;
using Microsoft.Extensions.Options;

namespace CloudSoft2.Storage;

public class AzureBlobImageService : IImageService
{
    private readonly string _blobContainerUrl;

    public AzureBlobImageService(IOptions<AzureBlobOptions> options)
    {
        _blobContainerUrl = options.Value.ContainerUrl;
    }

    public string GetImageUrl(string imageName)
    {
        // Azure Blob Storage URLs are case sensitive
        // For production, images will be served directly from the Blob Storage CDN
        return $"{_blobContainerUrl}/{imageName}";
    }
}