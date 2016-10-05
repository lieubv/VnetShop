using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class CommandDictionaryRepository : RepositoryBase<CommandDictionary>
    {
        public CommandDictionaryRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}