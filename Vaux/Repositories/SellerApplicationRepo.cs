using AutoMapper;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Repositories.Interface;
using Vaux.Models.Enums;

namespace Vaux.Repositories
{
    public class SellerApplicationRepo : ISellerApplicationRepo
    {
        private VxDbc _vxDbc;
        private IMapper _mapper;

        public SellerApplicationRepo(VxDbc dbc, IMapper mapper)
        {
            _vxDbc = dbc;
            _mapper = mapper;
        }
        public SellerApplication SendApplication(SellerApplicationDTO application)
        {
            var a = _mapper.Map<SellerApplication>(application);
            a.Status = SellerApplicationStatus.PENDING;

            _vxDbc.SellerApplications.Add(a);
            _vxDbc.SaveChanges();
            return a;
        }

        public SellerApplication UpdateApplication(SellerApplicationDTO application)
        {
            throw new NotImplementedException();
        }
    }
}
