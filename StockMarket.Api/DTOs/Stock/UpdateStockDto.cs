﻿namespace StockMarket.Api.DTOs;

public class UpdateStockDto
{
	[Required]
	[MaxLength(10, ErrorMessage = "Symbol cannot be over 10 over characters")]
	public string Symbol { get; set; } = string.Empty;
	[Required]
	[MaxLength(10, ErrorMessage = "Company Name cannot be over 10 over characters")]
	public string CompanyName { get; set; } = string.Empty;
	[Required]
	[Range(1, 1000000000)]
	public decimal Price { get; set; }
	[Required]
	[Range(0.001, 100)]
	public decimal LatestProfit { get; set; }
	[Required]
	[MaxLength(10, ErrorMessage = "Industry cannot be over 10 characters")]
	public string Industry { get; set; } = string.Empty;
	[Range(1, 5000000000)]
	public long MarketValue { get; set; }
}
