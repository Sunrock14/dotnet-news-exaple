using Microsoft.Extensions.DependencyInjection;
using News.Services.Abstract;
using News.Services.Concrete;
using News.Services.Helper;

namespace News.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ApiHelper>();
        serviceCollection.AddScoped<INewsService, NewsManager>();
        return serviceCollection;
    
    }
}
