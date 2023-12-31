﻿using Microsoft.AspNetCore.Mvc.Formatters;
using System.Linq.Expressions;
using Vaux.DTO;
using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IItemRepo : IBaseRepo<Item>
    {
        public TOut Create<TOut, TIn>(TIn item, int seller);
        public TOut EditThumbnail<TOut>(Expression<Func<Item, bool>> predicate, IFormFile image);
        public TOut AddImages<TOut>(Expression<Func<Item, bool>> predicate, List<IFormFile> images);
        public TOut RemoveImages<TOut>(Expression<Func<Item, bool>> predicate, ICollection<int> imageIds);
        public TOut Update<TOut, TIn>(Expression<Func<Item, bool>> predicate, TIn data, string changeReason);
    }
}
