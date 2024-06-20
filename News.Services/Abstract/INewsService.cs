using News.Core.Response;
using News.Dtos.NewsDto;

namespace News.Services.Abstract;

public interface INewsService
{
    /// <summary>
    /// Verilen query veya category göre verileri sayfalama yaparak getirir
    /// </summary>
    /// <param name="query"></param>
    /// <param name="category"></param>
    /// <param name="currentPage"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<IDataResponse<GetNewsDto>> GetAllAsync(string query, string category, int currentPage=1, int pageSize=5);
    
    /// <summary>
    /// Haber detay sayfasındaki detay haberi çek
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    Task<IDataResponse<GetDetailDto>> GetDetailAsync(int Id);
}
