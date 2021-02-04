using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DaLance.Domain.Models;
using DaLance.Domain.Repositories;

namespace DaLance.Domain.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
    }
}
