using News.Core.Response;
using News.Dtos.NewsDto;

namespace News.Services.Abstract;

public interface INewsService
{
    Task<IDataResponse<GetNewsDto>> GetAllAsync(string query, string category, int currentPage=1, int pageSize=5);
    Task<IDataResponse<GetDetailDto>> GetDetailAsync(int Id);
}
