using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IPhotoRepo
    {
        public MemoryStream? Get(int id);
        public TOut Delete<TOut>(int id);
        public TOut Update<TOut>(int id, IFormFile image);
        public TOut Create<TOut>(IFormFile image);
    }
}
