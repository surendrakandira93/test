using EngineerPark.Data.IRepositories;
using EngineerPark.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngineerPark.Data.Repositories
{
    public class MasterDataRepository : IMasterDataRepository
    {
        private readonly ApplicationDbContext context;
        public MasterDataRepository(ApplicationDbContext context)
        {
            this.context = context;

        }
        public async Task<List<MasterDataView>> Execute(string sqlQuery)
        {
            try
            {

                var results = await context.MasterDataDB.SqlQuery(sqlQuery).ToListAsync();
                return results;                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
