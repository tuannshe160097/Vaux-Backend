using AutoMapper;
using System.Linq.Expressions;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class ChatRepo : BaseRepo<ChatMessage>, IChatRepo
    {
        public ChatRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {

        }

        public override TOut Create<TOut, TIn>(TIn message)
        {
            var i = Create(message);
            Save();
            return _mapper.Map<TOut>(i);
        }

        public override ResultListDTO<TOut> GetAll<TOut>(Expression<Func<ChatMessage, object>>? orderBy)
        {
            return GetAll<TOut>(null, orderBy);
        }
    }
}
