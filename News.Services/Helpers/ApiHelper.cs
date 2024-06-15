namespace News.Services.Helper;

public class ApiHelper : IApiHelper
{
    /// <summary>
    /// Verilen Url adresini istek atarak, veriyi string olarak döner
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public async Task<string> ApiGet(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;

            }
            catch (HttpRequestException ex)
            {
                return ex.Message;
            }
        }
    }


}
