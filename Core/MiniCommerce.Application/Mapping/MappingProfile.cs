using AutoMapper;
using MiniCommerce.Application.Features.Commands.Authentications.SignUp;
using MiniCommerce.Application.Features.Commands.Offers.Adds;
using MiniCommerce.Application.Features.Commands.Offers.Updates.ApproveOffer;
using MiniCommerce.Application.Features.Commands.Products.Adds;
using MiniCommerce.Application.Features.Commands.Products.Updates.BuyProduct;
using MiniCommerce.Application.Features.Commands.Products.Updates.SetProductOffer;
using MiniCommerce.Application.Features.Queries.Brands.GetBrands;
using MiniCommerce.Application.Features.Queries.Categories.GetAllCategories;
using MiniCommerce.Application.Features.Queries.Colors.GetColors;
using MiniCommerce.Application.Features.Queries.Offers.GetAllReceivedOffers;
using MiniCommerce.Application.Features.Queries.Offers.GetAllSubmittedOffers;
using MiniCommerce.Application.Features.Queries.Products.GetProductById;
using MiniCommerce.Application.Features.Queries.Products.GetProductList;
using MiniCommerce.Application.Features.Queries.Products.GetProductsByCategoryId;
using MiniCommerce.Application.Features.Queries.Products.GetProductsByUserId;
using MiniCommerce.Application.Features.Queries.Usages.GetUsages;
using MiniCommerce.Application.Models.Users;
using MiniCommerce.Domain.Entities;

namespace MiniCommerce.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Authentications

            CreateMap<SignUpUserCommand, User>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();

            #endregion

            #region Product

            CreateMap<AddProductCommand, Product>().ReverseMap();
            CreateMap<BuyProductCommand, Product>().ReverseMap();
            CreateMap<SetProductOfferCommand, Product>().ReverseMap();
            CreateMap<Product, GetAllProductsQueryResponse>();
            CreateMap<Product, GetProductsByCategoryIdQueryResponse>();
            CreateMap<Product, GetProductsByUserQueryResponse>();
            CreateMap<Product, GetProductByIdQueryResponse>()
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color.Name))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.Usage, opt => opt.MapFrom(src => src.Usage.Name))
                .ReverseMap(); ;

            #endregion
            
            #region Offer

            CreateMap<AddOfferCommand, Offer>().ReverseMap();
            CreateMap<ApproveOfferCommand, Offer>().ReverseMap();
            CreateMap<Offer, GetAllReceivedOffersQueryResponse>().ReverseMap();
            CreateMap<Offer, GetAllSubmittedOffersQueryResponse>().ReverseMap();

            #endregion

            #region Category

            CreateMap<Category, GetAllCategoriesQueryResponse>().ReverseMap();

            #endregion

            #region Usage

            CreateMap<Usage, GetAllUsagesQueryResponse>().ReverseMap();
            
            #endregion

            #region Color

            CreateMap<Color, GetAllColorsQueryResponse>().ReverseMap();
            
            #endregion

            #region Brand

            CreateMap<Brand, GetAllBrandsQueryResponse>().ReverseMap();
            
            #endregion





        }
    }
}
