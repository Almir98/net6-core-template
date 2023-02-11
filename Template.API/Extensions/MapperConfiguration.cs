using AutoMapper;

namespace Template.API.Extensions
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<object, object>().ReverseMap();
        }
    }
}
