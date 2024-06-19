using News.Core.Response;
using News.Dtos.NewsDto;
using News.Entities.Concrete;
using News.Services.Abstract;
using News.Services.Helper;
using System.Text.Json;

namespace News.Services.Concrete;

public class NewsManager : INewsService
{
    public async Task<IDataResponse<GetNewsDto>> GetAllAsync(string query, string category, int currentPage = 1, int pageSize = 5)
    {
        ApiHelper _apiHelper = new ApiHelper();
        var response = await _apiHelper.ApiGet("https://www.turkmedya.com.tr/anasayfa.json");
        var mappedNews = JsonSerializer.Deserialize<MainPage>(response);

        if (mappedNews.errorCode != 0) return new DataResponse<GetNewsDto>(400, "Error", null);

        var mergedItemList = mappedNews.data.First().itemList.Concat(mappedNews.data.Last().itemList).ToList();

        if (!string.IsNullOrEmpty(category))
        {
            mergedItemList = mergedItemList.Where(x => x.category.title == category.ToUpper()).ToList();
        }

        if (!string.IsNullOrEmpty(query))
        {
            mergedItemList = mergedItemList.Where(x => x.title.Contains(query)).ToList();

        }
        var pagingItemList = mergedItemList.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        return new DataResponse<GetNewsDto>(200, "", new GetNewsDto
        {
            Data = pagingItemList,
            TotalCount = mergedItemList.Count,
            CurrentPage = currentPage,
            PageSize = pageSize
        });
    }

    public async Task<IDataResponse<GetDetailDto>> GetDetailAsync(int Id)
    {
        ApiHelper _apiHelper = new ApiHelper();
        //var response = await _apiHelper.ApiGet($"https://www.turkmedya.com.tr/detay.json?itemId={Id}"); Id işlevsiz
        var response = await _apiHelper.ApiGet($"https://www.turkmedya.com.tr/detay.json");
        var mappedDetail = JsonSerializer.Deserialize<Detail>(response);
        if (mappedDetail.errorCode != 0) return new DataResponse<GetDetailDto>(400, "Error", null);

        return new DataResponse<GetDetailDto>(200, "", new GetDetailDto
        {
            Detail = mappedDetail
        });
    }
}
