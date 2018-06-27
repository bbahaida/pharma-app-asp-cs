using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public interface IStockMediDao
    {
        StockMedi AddStockMedi(StockMedi sm);
        StockMedi EditStockMedi(StockMedi sm);
        StockMedi DeleteStockMedi(StockMedi del);
        IEnumerable<StockMedi> GetAll();
        IEnumerable<StockMedi> GetStockMediByMedicament(Medicament m);
        IEnumerable<StockMedi> GetStockMediByStock(Stock s);
        StockMedi GetOneStockMediById(int ids,int idm);
    }
}
