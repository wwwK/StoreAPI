using AutoMapper;
using Store.Dtos;
using Store.Models;

namespace Store.Profiles
{
    public class ItemsProfile: Profile
    {
        public ItemsProfile()
        {
            CreateMap<Item, ItemReadDto>();
            CreateMap<ItemCreateDto, Item>();
            CreateMap<ItemUpdateDto, Item>();
            CreateMap<Item, ItemUpdateDto>();
        }
    }
}