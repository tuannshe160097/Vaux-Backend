namespace Vaux.Repositories.Interface
{
    public interface IPhotoRepo
    {
        public Task<string> DriveUpload(MemoryStream image, string name);

        public MemoryStream DriveDownloadFile(string fileId);
    }
}
