using AutoMapper;
using Vaux.DTO;
using Vaux.Models;

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

            CreateMap<UserMinimalNonOptionalDTO, User>()
                .ForMember(dest => dest.IsVerified, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<User, UserMinimalDTO>();
            CreateMap<User, UserOutDTO>();
            CreateMap<User, UserOutMinimalDTO>();

            CreateMap<UserStrictDTO, User>()
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.RoleId, opt => opt.Ignore());

            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Items, opt => opt.Ignore());

            CreateMap<Category, CategoryDTO>();

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

            CreateMap<Order, OrderOutDTO>();
            CreateMap<Shipment, ShipmentOutDTO>();

            CreateMap<SellerPayment, SellerPaymentOutDTO>();

            CreateMap<StatusChange, StatusChangeOutDTO>();
        }
    }
}
