using Microsoft.OpenApi.Models;
using SVCW.Interfaces;
using SVCW.Models;
using SVCW.Services;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(
    x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRole, RoleService>();
builder.Services.AddScoped<IAchivement, AchivementService>();
builder.Services.AddScoped<IReportType, ReportTypeService>();
builder.Services.AddScoped<IProcessType, ProcessTypeService>();
builder.Services.AddScoped<IVote, VoteService>();
builder.Services.AddScoped<IDonation,DonationService>();





builder.Services.AddScoped(typeof(SVCWContext));

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(option =>
//{
//    option.SwaggerDoc("SVCW", new OpenApiInfo() { Title = "SVCW", Version = "v1" });
//    //setup comment in swagger UI
//    //var xmlCommentFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    //var xmlCommentFileFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentFile);

//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseCors(x => x.AllowAnyOrigin()
                 .AllowAnyHeader()
                 .AllowAnyMethod());

//app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/SVCW/swagger.json", "SVCWAPIs v1"));

app.UseAuthorization();

app.MapControllers();

app.Run();
