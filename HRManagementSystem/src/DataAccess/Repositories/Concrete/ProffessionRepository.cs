namespace HRManagementSystem.DataAccess.Repositories.Concrete;
public class ProffessionRepository : Repository<Profession>, IProfessionRepository
{
    public ProffessionRepository(AppDbContext context) : base(context)
    {
    }
}
