namespace HelloEFCoreApp.ServiceContracts;

public interface IServiceManager
{
    IStudentService StudentService { get; }
    ICourсeService CourсeService { get; }
}
