namespace HelloEFCoreApp.RepositoryContracts;

public interface IRepositoryManager
{
    IStudentRepository StudentRepository { get; }
    ICourceRepository CourceRepository { get; }
    Task SaveAsync();
}
