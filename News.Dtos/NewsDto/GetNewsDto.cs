using News.Core.BaseDto;
using News.Entities.Concrete;

namespace News.Dtos.NewsDto;

public class GetNewsDto : PagenationDtoBase
{
    public List<MainPage.Itemlist> Data { get; set; } = new();

}

