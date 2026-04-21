//using AssessmentProject.Models;
//using AssessmentProject.Repositories.CustomRepo.CourseRepository;
//using AssessmentProject.Repositories.CustomRepo.StudentRepository;
//using AssessmentProject.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();
//builder.Services.Add();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddDbContext<ElsewedySchoolSysDbDevContext>(
//    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
//    ));
//builder.Services.AddScoped(typeof(IGenericRepo<>),typeof(GenericRepo<>));
//builder.Services.AddScoped<IStudentRepo, StudentRepo>();
//builder.Services.AddScoped<ICourseRepo, CourseRepo>();
var app = builder.Build();
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseDeveloperExceptionPage(); // Add before app.Run()
app.Run();
//Data Source=DESKTOP-TE2HID9;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30