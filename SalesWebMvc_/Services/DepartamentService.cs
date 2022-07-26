using Microsoft.EntityFrameworkCore;
using SalesWebMvc_.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc_.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMvc_Context _context;

        public DepartamentService(SalesWebMvc_Context context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
