using News.Entities.Concrete;

namespace News.Dtos.NewsDto;

public class GetNewsDto
{
    public MainPage MainPage { get; set; } = new();
}

