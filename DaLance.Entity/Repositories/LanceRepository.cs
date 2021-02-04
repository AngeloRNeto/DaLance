using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaLance.Domain.Models;
using DaLance.Domain.Repositories;

namespace DaLance.Entity.Repositories
{
    public class LanceRepository : BaseRepository<Lance>, ILanceRepository
    {
        private readonly DaLanceContext context;
        public LanceRepository(DaLanceContext context): base(context)
        {
            this.context = context;
        }
    }
}
