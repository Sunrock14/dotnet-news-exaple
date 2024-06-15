using News.Core.Response;
using News.Dtos.NewsDto;
using News.Entities.Concrete;
using News.Services.Abstract;
using News.Services.Helper;
using System;
using System.Net.Http.Json;
using System.Text.Json;

namespace News.Services.Concrete;

public class NewsManager : INewsService
{
    private ApiHelper _apiHelper;

    public NewsManager(ApiHelper apiHelper)
    {
        apiHelper = apiHelper;
    }

    public async Task<IDataResponse<GetNewsDto>> GetAllAsync()
    {
        var response = await _apiHelper.ApiContext("https://www.turkmedya.com.tr/anasayfa.json");
        var mappedNews = JsonSerializer.Deserialize<MainPage>(response);
        
        if (mappedNews.errorCode != 0) return new DataResponse<GetNewsDto>(400, "Error", null);

        return new DataResponse<GetNewsDto>(200, "", new GetNewsDto
        {
            MainPage = mappedNews
        });
    }

    public Task<IDataResponse<GetDetailDto>> GetDetailAsync(int Id)
    {
        throw new NotImplementedException();
    }
}
