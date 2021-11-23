using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class VenteServiceImpl : IVenteService
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(VenteServiceImpl));
        IVenteDao VenteDao;
        IVenteMediDao VenteMediDao;
        public VenteServiceImpl(IVenteDao vdao, IVenteMediDao vmdao)
        {
            VenteDao = vdao;
            VenteMediDao = vmdao;
        }
        public Vente AddVente(Vente v, User user)
        {

            Vente o = VenteDao.AddVente(v);
            if (o != null)
            {
                logger.Info(user.Login + " a ajouter le Stock {" + o.NumVente+","+o.MontantVente+"}");
                return o;
            }
            return null;
        }
        
        public Vente DeleteVente(Vente del, User user)
        {
            if (del != null)
            {
                List<VenteMedi> list = VenteMediDao.GetVenteMediByVente(del).ToList();
                if (list.Count == 0)
                {

                    Vente v = VenteDao.DeleteVente(del);
                    if (v == null)
                    {
                        logger.Info(user.Login + " a supprime le vente {" + del.NumVente + "," + del.MontantVente + "," + del.DateVente+"}");
                        return null;
                    }
                }
            }
            return del;
        }

        public Vente EditVente(Vente v, User user)
        {
            Vente o = VenteDao.EditVente(v);
            if (o != null)
            {
                logger.Info(user.Login + " a modifie le Stock de {" + v.NumVente + "," + v.MontantVente + "," + v.DateVente + "} a {" + o.NumVente + "," + o.MontantVente + ","+o.DateVente+"}");
                return o;
            }
            return null;
        }

        public IEnumerable<Vente> GetAll()
        {
            return VenteDao.GetAll();
        }

        public Vente GetOneVenteById(int id)
        {
            if (id > 0)
                return VenteDao.GetOneVenteById(id);
            return null;
        }

        public IEnumerable<Vente> GetVenteByDate(DateTime date)
        {
            if (date != null)
                return VenteDao.GetVenteByDate(date);
            return null;
        }
        public Dictionary<string,decimal> GetMontantPerDate()
        {
            return VenteDao.GetAll().GroupBy(v => v.DateVente.ToShortDateString()).ToDictionary(g => g.Key, g => g.Sum(v => v.MontantVente));
        }
    }
}
