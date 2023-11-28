using System.Linq.Expressions;
using Twilio.TwiML.Voice;
using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.Repositories.Interface
{
    public interface INotificationRepo
    {
        public ICollection<TOut> Create<TOut>(Expression<Func<User, bool>> predicate, string content, string? redirect = null);
        public TOut MarkAsRead<TOut>(Expression<Func<Notification, bool>> predicate);
    }
}
