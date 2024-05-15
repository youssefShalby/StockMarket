namespace StockMarket.Api.DTOs;

public class StockQueryHandler
{
    public string Symbol { get; set; } = null!;
    public string CompanyName { get; set; } = null!;
    public string SortBy { get; set; } = null!;
    public bool IsDescending { get; set; } = false;

    //> initial the first page by 1, because it's a first page bro
    public int PageNumber { get; set; } = 1;

    //> set 10 items in each page | get 10 by 10
    public int PageSize { get; set; } = 10;
}
