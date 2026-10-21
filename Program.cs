using Microsoft.EntityFrameworkCore;
using QuanLyNhanVienAPI.Data;
using QuanLyNhanVienAPI.Services;


var builder = WebApplication.CreateBuilder(args);
// tạo DI cho controller lấy service
builder.Services.AddScoped<INhanVienService, NhanVienServices>();
// tạo DI cho serives lấy db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// Add services to the container.

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
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
