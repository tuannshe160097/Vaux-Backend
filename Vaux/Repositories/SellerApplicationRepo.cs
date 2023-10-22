using AutoMapper;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;
using Vaux.Models.Enums;
using System.Linq.Expressions;

namespace Vaux.Repositories
{
    public class SellerApplicationRepo : BaseRepo<SellerApplication>, ISellerApplicationRepo
    {
        public SellerApplicationRepo(VxDbc vxDbc, IMapper mapper) : base(vxDbc, mapper)
        {
        }


        public override TOut Create<TOut, TIn>(TIn data)
        {
            var a = base.Create(data);
            a.Status = SellerApplicationStatus.PENDING;
            Save();          
            return _mapper.Map<TOut>(a);
        }

    }
}
