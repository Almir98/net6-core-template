namespace Template.Application.Mapper;

public class Mapper : Profile
{
    public Mapper()
    {
        //CreateMap<TemplateEntity1Dto, TemplateEntity1>().ReverseMap();
        CreateMap<TemplateEntity2Dto, TemplateEntity2>().ReverseMap();
    }
}