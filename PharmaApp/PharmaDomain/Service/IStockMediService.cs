using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public interface IStockMediService
    {
        StockMedi AddStockMedi(StockMedi sm, User user);
        StockMedi EditStockMedi(StockMedi sm, User user);
        StockMedi DeleteStockMedi(StockMedi del, User user);
        IEnumerable<StockMedi> GetAll();
        StockMedi GetOneStockMediById(int ids, int idm);
        IEnumerable<StockMedi> GetStockMediByMedicament(Medicament m);
        IEnumerable<StockMedi> GetStockMediByStock(Stock s);
        int GetQuantityByStock(Medicament m, Stock s);
        int GetAllQuantity(Medicament m);
    }
}
