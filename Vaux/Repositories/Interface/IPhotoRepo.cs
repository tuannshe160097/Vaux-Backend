namespace Vaux.Repositories.Interface
{
    public interface IPhotoRepo
    {
        public Task<string> DriveUpload(IFormFile formFile, string name);

        public MemoryStream DriveDownloadFile(string fileId);
    }
}
