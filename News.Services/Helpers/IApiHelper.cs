using News.Core.Response;
using News.Dtos.NewsDto;

namespace News.Services.Helper;

public interface IApiHelper
{
    Task<string> ApiGet(string url);
}
