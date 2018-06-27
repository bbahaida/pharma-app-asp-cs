using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class StockServiceImpl : IStockService
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(StockServiceImpl));
        IStockDao StockDao;
        IStockMediDao StockMediDao;
        public StockServiceImpl(IStockDao sdao,IStockMediDao smdao)
        {
            StockDao = sdao;
            StockMediDao = smdao;
        }
        public Stock AddStock(Stock s, User user)
        {
            
            Stock o = StockDao.AddStock(s);
            if (o != null)
            {
                logger.Info(user.Login + " a ajouter le Stock " + o.NumStock);
                return o;
            }
            return null;
        }

        public Stock DeleteStock(Stock del, User user)
        {
            if (del != null)
            {
                List<StockMedi> list = StockMediDao.GetStockMediByStock(del).ToList();
                if (list.Count == 0)
                {

                    Stock s = StockDao.DeleteStock(del);
                    if (s == null)
                    {
                        logger.Info(user.Login + " a supprime le stock " + del.NumStock);
                        return null;
                    }
                }
            }
            return del;
        }

        public Stock EditStock(Stock s, User user)
        {
            Stock o = StockDao.EditStock(s);
            if (o != null)
            {
                logger.Info(user.Login + " a modifier le Stock de {" + s.NumStock+","+s.QuantiteMedicament+ "} a {" + o.NumStock + "," + o.QuantiteMedicament + "}");
                return o;
            }
            return null;
        }

        public IEnumerable<Stock> GetAll()
        {
            return StockDao.GetAll();
        }

        public Stock GetOneStockById(int id)
        {
            if(id > 0)
                return StockDao.GetOneStockById(id);
            return null;
        }
    }
}
