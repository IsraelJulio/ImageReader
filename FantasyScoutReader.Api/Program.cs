using FantasyScoutReader.Api.Services;
using FantasyScoutReader.Api.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IScoutImageReaderService, ScoutImageReaderService>();
builder.Services.AddScoped<IAiScoutPromptBuilder, AiScoutPromptBuilder>();
builder.Services.AddScoped<IAiScoutClient, OpenAiScoutClient>();
builder.Services.Configure<OpenAiSettings>(
    builder.Configuration.GetSection("OpenAI"));
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();