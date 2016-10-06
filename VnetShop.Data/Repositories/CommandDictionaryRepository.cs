using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface ICommandDictionaryRepository : IRepository<CommandDictionary>
    {

    }
    public class CommandDictionaryRepository : RepositoryBase<CommandDictionary>, ICommandDictionaryRepository
    {
        public CommandDictionaryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}