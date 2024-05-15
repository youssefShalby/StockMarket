namespace StockMarket.Api.SeedData;

public class CommentDummyData
{
	public static List<Comment> comments = new List<Comment>
	{
		// Comments for AAPL (Apple Inc.)
		new Comment
		{
			Id = 1,
			Title = "Great company!",
			Content = "Apple has consistently produced innovative products.",
			CreatedOn = DateTime.Now.AddDays(-5),
			StockId = 1
		},
		new Comment
		{
			Id = 2,
			Title = "Rising stock price",
			Content = "AAPL's stock price has been steadily increasing.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 1
		},
		new Comment
		{
			Id = 3,
			Title = "Future prospects",
			Content = "Excited about Apple's upcoming product launches.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 1
		},

		// Comments for MSFT (Microsoft Corporation)
		new Comment
		{
			Id = 4,
			Title = "Strong growth",
			Content = "Microsoft's cloud business is driving impressive growth.",
			CreatedOn = DateTime.Now.AddDays(-7),
			StockId = 2
		},
		new Comment
		{
			Id = 5,
			Title = "Tech giant",
			Content = "MSFT remains one of the largest tech companies globally.",
			CreatedOn = DateTime.Now.AddDays(-4),
			StockId = 2
		},
		new Comment
		{
			Id = 6,
			Title = "Diverse portfolio",
			Content = "Microsoft's products span from software to hardware, providing stability.",
			CreatedOn = DateTime.Now.AddDays(-2),
			StockId = 2
		},

		// Comments for AMZN (Amazon.com Inc.)
		new Comment
		{
			Id = 7,
			Title = "E-commerce dominance",
			Content = "Amazon's e-commerce platform continues to dominate the market.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 3
		},
		new Comment
		{
			Id = 8,
			Title = "Innovative company",
			Content = "AMZN's investments in technology and logistics drive innovation.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 3
		},
		new Comment
		{
			Id = 9,
			Title = "Expanding cloud business",
			Content = "Amazon Web Services (AWS) remains a key driver of growth.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 3
		},

		// Comments for GOOGL (Alphabet Inc.)
		new Comment
		{
			Id = 10,
			Title = "Search engine dominance",
			Content = "Google's search engine continues to dominate the market.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 4
		},
		new Comment
		{
			Id = 11,
			Title = "Innovative projects",
			Content = "GOOGL's moonshot projects demonstrate their commitment to innovation.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 4
		},
		new Comment
		{
			Id = 12,
			Title = "Advertising revenue",
			Content = "Google's advertising business remains a significant revenue driver.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 4
		},

		// Comments for FB (Meta Platforms Inc.)
		new Comment
		{
			Id = 13,
			Title = "Social media giant",
			Content = "Facebook's social media platforms continue to attract billions of users.",
			CreatedOn = DateTime.Now.AddDays(-7),
			StockId = 5
		},
		new Comment
		{
			Id = 14,
			Title = "Metaverse initiatives",
			Content = "Meta Platforms' focus on the metaverse is generating significant interest.",
			CreatedOn = DateTime.Now.AddDays(-4),
			StockId = 5
		},
		new Comment
		{
			Id = 15,
			Title = "Data privacy concerns",
			Content = "Concerns about data privacy continue to impact FB's reputation.",
			CreatedOn = DateTime.Now.AddDays(-2),
			StockId = 5
		},

		// Comments for TSLA (Tesla Inc.)
		new Comment
		{
			Id = 16,
			Title = "Electric vehicle leader",
			Content = "Tesla's electric vehicles continue to lead the market.",
			CreatedOn = DateTime.Now.AddDays(-5),
			StockId = 6
		},
		new Comment
		{
			Id = 17,
			Title = "Innovative technology",
			Content = "TSLA's advancements in battery technology are impressive.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 6
		},
		new Comment
		{
			Id = 18,
			Title = "Production challenges",
			Content = "Tesla faces challenges in scaling production to meet demand.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 6
		},

		// Comments for BRK-A (Berkshire Hathaway Inc.)
		new Comment
		{
			Id = 19,
			Title = "Value investing",
			Content = "Warren Buffett's value investing approach remains influential.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 7
		},
		new Comment
		{
			Id = 20,
			Title = "Diverse portfolio",
			Content = "BRK-A's portfolio includes a wide range of businesses.",
			CreatedOn = DateTime.Now.AddDays(-4),
			StockId = 7
		},
		new Comment
		{
			Id = 21,
			Title = "Investment strategy",
			Content = "Berkshire Hathaway's long-term investment strategy is well-respected.",
			CreatedOn = DateTime.Now.AddDays(-2),
			StockId = 7
		},

		// Comments for NVDA (NVIDIA Corporation)
		new Comment
		{
			Id = 22,
			Title = "Graphics technology leader",
			Content = "NVIDIA's graphics technology remains at the forefront of the industry.",
			CreatedOn = DateTime.Now.AddDays(-5),
			StockId = 8
		},
		new Comment
		{
			Id = 23,
			Title = "Gaming market dominance",
			Content = "NVDA's GPUs continue to dominate the gaming market.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 8
		},
		new Comment
		{
			Id = 24,
			Title = "AI and data center growth",
			Content = "NVIDIA's AI and data center segments are driving significant growth.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 8
		},

		// Comments for JPM (JPMorgan Chase & Co.)
		new Comment
		{
			Id = 25,
			Title = "Financial services leader",
			Content = "JPM is one of the largest financial institutions globally.",
			CreatedOn = DateTime.Now.AddDays(-7),
			StockId = 9
		},
		new Comment
		{
			Id = 26,
			Title = "Diversified business model",
			Content = "JPMorgan Chase's business model spans retail banking to investment banking.",
			CreatedOn = DateTime.Now.AddDays(-4),
			StockId = 9
		},
		new Comment
		{
			Id = 27,
			Title = "Regulatory challenges",
			Content = "Regulatory scrutiny remains a challenge for JPM and other banks.",
			CreatedOn = DateTime.Now.AddDays(-2),
			StockId = 9
		},

		// Comments for V (Visa Inc.)
		new Comment
		{
			Id = 28,
			Title = "Global payments leader",
			Content = "Visa's payment network facilitates billions of transactions globally.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 10
		},
		new Comment
		{
			Id = 29,
			Title = "Digital payments growth",
			Content = "V's investments in digital payments are driving growth.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 10
		},
		new Comment
		{
			Id = 30,
			Title = "Partnership strategies",
			Content = "Visa's partnerships with fintech companies strengthen its position.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 10
		},

		// Comments for PG (Procter & Gamble Co.)
		new Comment
		{
			Id = 31,
			Title = "Consumer goods giant",
			Content = "Procter & Gamble's brands are household names worldwide.",
			CreatedOn = DateTime.Now.AddDays(-5),
			StockId = 11
		},
		new Comment
		{
			Id = 32,
			Title = "Product innovation",
			Content = "PG continues to innovate with new product offerings.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 11
		},
		new Comment
		{
			Id =33,
			Title = "Global market presence",
			Content = "Procter & Gamble operates in over 180 countries.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 11
		},

		// Comments for DIS (The Walt Disney Company)
		new Comment
		{
			Id = 34,
			Title = "Entertainment powerhouse",
			Content = "Disney's entertainment properties span movies, TV, and theme parks.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 12
		},
		new Comment
		{
			Id = 35,
			Title = "Streaming growth",
			Content = "DIS's streaming services continue to gain subscribers.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 12
		},
		new Comment
		{
			Id = 36,
			Title = "Theme park recovery",
			Content = "Disney's theme parks are seeing a gradual recovery in attendance.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 12
		},

		// Comments for HD (The Home Depot Inc.)
		new Comment
		{
			Id = 37,
			Title = "Home improvement leader",
			Content = "Home Depot is the largest home improvement retailer in the U.S.",
			CreatedOn = DateTime.Now.AddDays(-5),
			StockId = 13
		},
		new Comment
		{
			Id = 38,
			Title = "DIY trend",
			Content = "HD benefits from the trend of consumers doing home improvement projects.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 13
		},
		new Comment
		{
			Id = 39,
			Title = "E-commerce growth",
			Content = "Home Depot's online sales continue to grow.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 13
		},

		// Comments for CMCSA (Comcast Corporation)
		new Comment
		{
			Id = 40,
			Title = "Telecommunications leader",
			Content = "Comcast is one of the largest telecommunications companies in the U.S.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 14
		},
		new Comment
		{
			Id = 41,
			Title = "Broadband expansion",
			Content = "CMCSA is expanding its broadband infrastructure.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 14
		},
		new Comment
		{
			Id = 42,
			Title = "Media acquisitions",
			Content = "Comcast's acquisitions in media strengthen its content portfolio.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 14
		},

		// Comments for UNH (UnitedHealth Group Incorporated)
		new Comment
		{
			Id = 43,
			Title = "Healthcare giant",
			Content = "UnitedHealth is one of the largest healthcare companies in the U.S.",
			CreatedOn = DateTime.Now.AddDays(-7),
			StockId = 15
		},
		new Comment
		{
			Id = 44,
			Title = "Healthcare services",
			Content = "UNH offers a wide range of healthcare services.",
			CreatedOn = DateTime.Now.AddDays(-4),
			StockId = 15
		},
		new Comment
		{
			Id = 45,
			Title = "Insurance segment",
			Content = "UnitedHealth's insurance segment remains profitable.",
			CreatedOn = DateTime.Now.AddDays(-2),
			StockId = 15
		},

		// Comments for BABA (Alibaba Group Holding Limited)
		new Comment
		{
			Id = 46,
			Title = "E-commerce leader",
			Content = "Alibaba is the largest e-commerce company in China.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 16
		},
		new Comment
		{
			Id = 47,
			Title = "Cloud computing growth",
			Content = "BABA's cloud computing business continues to grow rapidly.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 16
		},
		new Comment
		{	
			Id = 48,
			Title = "Regulatory challenges",
			Content = "Alibaba faces regulatory challenges in China.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 16
		},

		// Comments for PYPL (PayPal Holdings Inc.)
		new Comment
		{
			Id = 49,
			Title = "Digital payments leader",
			Content = "PayPal is a leading provider of digital payment solutions.",
			CreatedOn = DateTime.Now.AddDays(-5),
			StockId = 17
		},
		new Comment
		{
			Id = 50,
			Title = "Mobile payment growth",
			Content = "PYPL's mobile payment volume continues to grow.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 17
		},
		new Comment
		{
			Id = 51,
			Title = "Partnership strategies",
			Content = "PayPal's partnerships with merchants drive adoption.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 17
		},

		// Comments for NFLX (Netflix Inc.)
		new Comment
		{
			Id = 52,
			Title = "Streaming leader",
			Content = "Netflix remains the dominant player in the streaming industry.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 18
		},
		new Comment
		{
			Id = 53,
			Title = "Content production",
			Content = "NFLX invests heavily in original content production.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 18
		},
		new Comment
		{
			Id = 54,
			Title = "Subscriber growth",
			Content = "Netflix continues to add subscribers globally.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 18
		},

		// Comments for CRM (Salesforce.com Inc.)
		new Comment
		{
			Id = 55,
			Title = "CRM leader",
			Content = "Salesforce is the leading provider of customer relationship management software.",
			CreatedOn = DateTime.Now.AddDays(-7),
			StockId = 19
		},
		new Comment
		{
			Id = 56,
			Title = "Cloud computing growth",
			Content = "CRM's cloud computing segment is driving revenue growth.",
			CreatedOn = DateTime.Now.AddDays(-4),
			StockId = 19
		},
		new Comment
		{
			Id = 57,
			Title = "Acquisition strategy",
			Content = "Salesforce's acquisitions expand its product offerings.",
			CreatedOn = DateTime.Now.AddDays(-2),
			StockId = 19
		},

		// Comments for INTC (Intel Corporation)
		new Comment
		{
			Id = 58,
			Title = "Semiconductor leader",
			Content = "Intel is one of the largest semiconductor companies globally.",
			CreatedOn = DateTime.Now.AddDays(-6),
			StockId = 20
		},
		new Comment
		{
			Id = 59,
			Title = "Processor innovation",
			Content = "INTC's processors power a wide range of computing devices.",
			CreatedOn = DateTime.Now.AddDays(-3),
			StockId = 20
		},
		new Comment
		{
			Id = 60,
			Title = "Competition in data center market",
			Content = "Intel faces competition from AMD and other players in the data center market.",
			CreatedOn = DateTime.Now.AddDays(-1),
			StockId = 20
		},
	};


}
