using Dapper.Demo.Dapper.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Demo.Dapper.Infrastructure
{
    public class UnitOfWork : IUnitOfWork

    {
        public UnitOfWork(IProductRepository publicRepository)
        {
            Products = publicRepository;
        }
        public IProductRepository Products { get; }
    }
}
