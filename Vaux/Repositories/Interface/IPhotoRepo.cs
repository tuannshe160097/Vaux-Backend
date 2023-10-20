using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IPhotoRepo
    {
        public Task<string> DriveUpload(FileStream image, string name);

        public MemoryStream DriveDownload(string fileId);
    }
}