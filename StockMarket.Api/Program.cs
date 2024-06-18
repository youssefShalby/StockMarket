

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//> register connection string
string connectionString = builder.Configuration.GetConnectionString("StockMarket") ?? "";
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddScoped<ICommentRepo, CommentRepo>();
builder.Services.AddScoped<IStockRepo, StockRepo>();
builder.Services.AddScoped<IHandlerService, HandlerService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPortfolioRepo, PortfolioRepo>();
builder.Services.AddScoped<IPortfolioService, PortfolioService>();

//> register Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(option =>
{
	option.Password.RequiredLength = 10;
	option.Password.RequireUppercase = true;
	option.Password.RequireLowercase = true;
	option.User.RequireUniqueEmail = true;

	option.Lockout.MaxFailedAccessAttempts = 5;
	option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);

}).AddEntityFrameworkStores<AppDbContext>();

//> register and configure authentication service
var result = builder.Services.AddAuthentication(option =>
{
	option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
});

result.AddJwtBearer(option =>
{
	option.SaveToken = true;
	option.RequireHttpsMetadata = false;

	option.TokenValidationParameters = new()
	{
		ValidateIssuer = true,
		ValidateAudience = false,
		ValidIssuer = builder.Configuration["JWT:issuer"],
		ValidateIssuerSigningKey = true,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:secretKey"]))
	};
});

//> swager authorization service
builder.Services.AddSwaggerGen(setup =>
{
	// Include 'SecurityScheme' to use JWT Authentication
	var jwtSecurityScheme = new OpenApiSecurityScheme
	{
		BearerFormat = "JWT",
		Name = "JWT Authentication",
		In = ParameterLocation.Header,
		Type = SecuritySchemeType.Http,
		Scheme = JwtBearerDefaults.AuthenticationScheme,
		Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

		Reference = new OpenApiReference
		{
			Id = JwtBearerDefaults.AuthenticationScheme,
			Type = ReferenceType.SecurityScheme
		}
	};

	setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

	setup.AddSecurityRequirement(new OpenApiSecurityRequirement
	{
		{ jwtSecurityScheme, Array.Empty<string>() }
	});

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
