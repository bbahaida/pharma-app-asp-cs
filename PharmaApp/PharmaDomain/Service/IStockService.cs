using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IStockService
    {
        Stock AddStock(Stock s, User user);
        Stock EditStock(Stock s, User user);
        Stock DeleteStock(Stock del, User user);
        IEnumerable<Stock> GetAll();
        Stock GetOneStockById(int id);
    }
}
