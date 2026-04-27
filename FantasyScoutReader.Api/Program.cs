using FantasyScoutReader.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IScoutImageReaderService, ScoutImageReaderService>();
builder.Services.AddScoped<IAiScoutPromptBuilder, AiScoutPromptBuilder>();
builder.Services.AddScoped<IAiScoutClient, FakeAiScoutClient>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();