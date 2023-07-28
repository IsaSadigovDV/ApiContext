using ApiIntro.Core.Entities;
using ApiIntro.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntro.Core.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
    }
}
