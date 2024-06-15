using News.Core.Response;
using News.Dtos.NewsDto;

namespace News.Services.Abstract;

public interface INewsService
{
    Task<IDataResponse<GetNewsDto>> GetAllAsync();
    Task<IDataResponse<GetDetailDto>> GetDetailAsync(int Id);
}
