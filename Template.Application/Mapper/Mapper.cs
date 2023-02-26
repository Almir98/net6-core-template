namespace Template.Application.Mapper
{
    public class Mapper<> : Profile
    {
        public Mapper()
        {
            CreateMap<, object>().ReverseMap();


        }
    }
}
