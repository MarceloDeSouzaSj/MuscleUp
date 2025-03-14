namespace MuscleUp.Dominio.DataBase;

public interface IAppDbContext
{
    //DbSet<Colaborador> Colaboradores { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
