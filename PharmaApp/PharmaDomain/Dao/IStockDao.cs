using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IStockDao
    {
        Stock AddStock(Stock s);
        Stock EditStock(Stock s);
        Stock DeleteStock(Stock del);
        IEnumerable<Stock> GetAll();
        Stock GetOneStockById(int id);
    }
}
