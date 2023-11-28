using AutoMapper;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Claims;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class NotificationRepo : INotificationRepo
    {
        private readonly VxDbc _vxDbc;
        private readonly IMapper _mapper;

        public NotificationRepo(VxDbc vxDbc, IMapper mapper)
        {
            _vxDbc = vxDbc;
            _mapper = mapper;
        }

        public TOut MarkAsRead<TOut>(Expression<Func<Notification, bool>> predicate)
        {
            var noti = _vxDbc.Notifications.FirstOrDefault(predicate);
            noti.Seen = true;
            _vxDbc.SaveChanges();

            return _mapper.Map<TOut>(noti);
        }

        public ICollection<TOut> Create<TOut>(Expression<Func<User, bool>> predicate, string content, string? redirect = null)
        {
            List<Notification> notifications = new();
            var users = _vxDbc.Users.Where(predicate);

            foreach (var user in users)
            {
                Notification noti = new();
                noti.Content = content;
                noti.Redirect = redirect;
                user.Notifications!.Add(noti);
                notifications.Add(noti);
            }

            _vxDbc.SaveChanges();

            return _mapper.Map<List<TOut>>(notifications);
        }
    }
}
