namespace Vaux.Repositories.Interface
{
    public interface IPhotoRepo
    {
        public Task<string> DriveUpload(IFormFile formFile, string name);

        public MemoryStream DriveDownloadFile(string fileId);
        public Task<string> DriveUpdate(IFormFile formFile, string fileId, string name);
        public string DriveDelete(string fileId);
    }
}
