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
    }
}
