namespace Template.API.Extensions;

/// <summary>
/// Represents a mapper configuration that defines how objects are mapped between different types. 
/// </summary>
public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        // <Model, Entity>

        CreateMap<object, object>().ReverseMap();
    }
}