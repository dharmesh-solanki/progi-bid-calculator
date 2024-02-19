using Microsoft.AspNetCore.Mvc;
using ProgiBidCalculator.Domain.BaseCalculator;
using ProgiBidCalculator.Domain.BidCalculatorModels;
using ProgiBidCalculator.Domain.Services.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddMvcCore(option => option.EnableEndpointRouting = true).AddJsonOptions(options => options.JsonSerializerOptions.TypeInfoResolverChain.Add(MyJsonContext.Default));
builder.Services.AddScoped<IBidCalculatorService, BidCalculatorService>();
builder.Services.AddCors();

builder.Services.Configure<ApiBehaviorOptions>(opt =>
{
    opt.SuppressModelStateInvalidFilter = true;
});


var app = builder.Build();
app.MapControllers();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.Run();

[JsonSerializable(typeof(BidCalculationRequest[]))]
[JsonSerializable(typeof(BidCalculationResponse[]))]
public partial class MyJsonContext : JsonSerializerContext { }
