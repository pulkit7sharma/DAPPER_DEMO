using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Demo.Dapper.Application
{
    public interface IUnitOfWork
    {
        public IProductRepository Products { get; }
    }
}
