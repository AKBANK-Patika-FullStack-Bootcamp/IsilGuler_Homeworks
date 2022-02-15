using Business.Abstract;
using Business.Concrete;
using Core;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<PaymentDBSettings>(
    builder.Configuration.GetSection(nameof(PaymentDBSettings)));

builder.Services.AddSingleton<IPaymentDBSettings>(sp =>
sp.GetRequiredService<IOptions<PaymentDBSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("PaymentDBSettings:ConnectionString")));

builder.Services.AddScoped<IPaymentService, PaymentManager>();

//final

/*builder.Services.Configure<PaymentRequestDBSettings>(
    builder.Configuration.GetSection(nameof(PaymentRequestDBSettings)));

builder.Services.AddSingleton<PaymentRequestDBSettings>(sp =>
sp.GetRequiredService<IOptions<PaymentRequestDBSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("PaymentRequestDBSettings:ConnectionString")));*/

builder.Services.AddScoped<IPaymentRequestService, PaymentRequestManager>();

//final2

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
