using HelloEFCoreApp.Data;
using HelloEFCoreApp.Dto;
using HelloEFCoreApp.Repositories;
using HelloEFCoreApp.RepositoryContracts;
using HelloEFCoreApp.ServiceContracts;
using HelloEFCoreApp.Services;
using Microsoft.Extensions.DependencyInjection; // DI

IServiceCollection services = new ServiceCollection();

// Register Services
services.AddDbContext<ApplicationDbContext>(); // register context

services.AddAutoMapper(typeof(Program));

services.AddScoped<IStudentService, StudentService>();
services.AddScoped<ICourсeService, CourceService>();
services.AddScoped<IServiceManager, ServiceManager>();

services.AddScoped<IStudentRepository, StudentRepository>();
services.AddScoped<ICourceRepository, CourceRepository>();
services.AddScoped<IRepositoryManager, RepositoryManager>();

using ServiceProvider sp = services.BuildServiceProvider();


// Client code:
// Get context as a Scope and init DB
using (var scope = services.BuildServiceProvider().CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

	//await context.Database.EnsureDeletedAsync();
	await context.Database.EnsureCreatedAsync();

	await DataInitializer.Init(context);
}


// Test Dependency Injection using IStudentService
var sm = sp.GetRequiredService<IServiceManager>();

IEnumerable<StudentDto> students = await sm.StudentService
	.GetAllStudentsAsync(false);

foreach (var student in students)
{
	Console.WriteLine($"{student.Id}, {student.Name}");
}
Console.WriteLine();


IEnumerable<StudentDto> studentsByCondition = await sm.StudentService
	.GetAllStudentsByConditionAsync(false, "ce");

foreach (var student in studentsByCondition)
{
    Console.WriteLine($"{student.Id}, {student.Name}");
}










