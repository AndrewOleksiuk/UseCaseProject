using UseCaseProject.HttpClients;
using UseCaseProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient("https://restcountries.com/v3.1/all");
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("https://restcountries.com/v3.1/all"));
builder.Services.AddScoped<ITypedHttpClient, TypedHttpClient>();
builder.Services.AddScoped<IDataService, DataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
