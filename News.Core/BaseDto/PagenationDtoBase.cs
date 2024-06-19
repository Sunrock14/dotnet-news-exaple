namespace News.Core.BaseDto;

/// <summary>
/// Sayfalama ile alakalı 
/// </summary>
public abstract class PagenationDtoBase
{
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 5;
    public int TotalCount { get; set; }
    public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
    public bool ShowPrevious => CurrentPage > 1;
    public bool ShowNext => CurrentPage < TotalPages;
}
