using AutoMapper;
using Vaux.DTO;
using Vaux.DTO.In;
using Vaux.DTO.Out;
using Vaux.Models;
using Vaux.Repositories;

namespace Vaux.MapperProfiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile() 
        {
            CreateMap<UserMinimalDTO, User>()
                .ForMember(dest => dest.IsVerified, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<RegisterDTO, User>()
                .ForMember(dest => dest.IsVerified, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<User, UserMinimalDTO>();
            CreateMap<User, UserOutDTO>()
                .ForMember(dest => dest.Notifications, opt => opt.MapFrom(src => src.Notifications!.OrderByDescending(e => e.Id)));
            CreateMap<User, UserOutMinimalDTO>();

            CreateMap<Notification, NotificationOutDTO>();

            CreateMap<UserStrictDTO, User>()
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<UserWithPhotoDTO, User>();

            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Items, opt => opt.Ignore());

            CreateMap<Category, CategoryOutDTO>();

            CreateMap<ItemApplicationDTO, Item>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ItemPropertiesDTO, Item>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ItemPropertyDTO, ItemProperty>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<ItemProperty, ItemPropertyDTO>();

            CreateMap<Item, ItemWithBidsOutDTO>()
                .ForMember(dest => dest.StatusString, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.AuctionSessions, opt => opt.MapFrom(src => src.AuctionSessions!.OrderByDescending(e => e.EndDate)))
                .ForMember(dest => dest.Bids, opt => opt.MapFrom(src => src.Bids!.OrderByDescending(e => e.Id)))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images != null ? src.Images.Select(e => e.Id) : null));

            CreateMap<Item, ItemOutDTO>()
                .ForMember(dest => dest.StatusString, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.AuctionSessions, opt => opt.MapFrom(src => src.AuctionSessions!.OrderByDescending(e => e.EndDate)))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images != null ? src.Images.Select(e => e.Id) : null));

            CreateMap<SellerApplicationDTO, SellerApplication>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<SellerApplication, SellerApplicationDTO>();
            CreateMap<SellerApplication, SellerApplicationOutDTO>();

            CreateMap<SellerApplication, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<AuctionSessionUploadDTO, AuctionSession>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<AuctionSession, AuctionSessionIFullDTO>();

            CreateMap<AuctionSession, AuctionSessionMinimalDTO>();

            CreateMap<Comment, CommentOutDTO>();

            CreateMap<Bid, BidOutDTO>();
            
            CreateMap<ChatMessageDTO, ChatMessage>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<ChatMessage, ChatMessageOutDTO>()
                .ForMember(dest => dest.Sender, src => src.MapFrom(c => c.Sender!.Name))
                .ForMember(dest => dest.SenderId, src => src.MapFrom(c => c.SenderId));

            CreateMap<OrderPaymentDTO, Order>();
            CreateMap<Order, OrderOutDTO>();
            CreateMap<Shipment, ShipmentOutDTO>()
                .ForMember(dest => dest.BuyerProtectionFee, src => src.MapFrom(s => s.Items.Sum(e => OrderRepo.CalculateBuyerProtectionFee(e.HighestBid!.Amount) )));

            CreateMap<ItemPayment, ItemPaymentOutDTO>()
                .ForMember(dest => dest.BidAmount, src => src.MapFrom(i => i.Item!.HighestBid!.Amount));

            CreateMap<StatusChange, StatusChangeOutDTO>();
        }
    }
}
