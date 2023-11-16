﻿using AutoMapper;
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
            var a = Create(data);
            a.Status = SellerApplicationStatus.PENDING;
            Save();          
            return _mapper.Map<TOut>(a);
        }

        public TOut Update<TOut, TIn>(Expression<Func<SellerApplication, bool>> predicate, TIn data, string changeReason)
        {
            var oldAppli = Get<SellerApplication>(predicate);
            var newAppli = Update(predicate, data);

            if (oldAppli.Status != newAppli.Status && _user != null)
            {
                StatusChange sc = new StatusChange();
                sc.StatusFrom = nameof(oldAppli.Status);
                sc.StatusFrom = nameof(newAppli.Status);

                sc.StatusChangedById = int.Parse(_user.Identity.Name);
                sc.StatusChangeReason = changeReason;
            }

            Save();

            return _mapper.Map<TOut>(newAppli);
        }
    }
}
