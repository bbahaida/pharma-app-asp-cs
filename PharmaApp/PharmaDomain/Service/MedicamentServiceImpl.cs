using PharmaDomain.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Service
{
    public class MedicamentServiceImpl : IMedicamentService
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(MedicamentServiceImpl));
        IMedicamentDao MedicamentDao;
        IVenteMediDao VenteMediDao;
        IStockMediDao StockMediDao;

        public MedicamentServiceImpl(IMedicamentDao mdao,IVenteMediDao vdao,IStockMediDao sdao)
        {
            MedicamentDao = mdao;
            VenteMediDao = vdao;
            StockMediDao = sdao;
        }


        public Medicament AddMedicament(Medicament m, User user)
        {
            if (m != null)
            {
                if (MedicamentDao.GetMedicamentByLibelle(m.LibelleMedicament) == null)
                {
                    Medicament o = MedicamentDao.AddMedicament(m);
                    if (o != null)
                    {
                        logger.Info(user.Login + " a ajouter le medicament {" + o.LibelleMedicament + "," + o.Prix + "," + o.CodeFamille + "}");
                        return o;
                    }
                }
            }

            return null;
        }

        public Medicament DeleteMedicament(Medicament del, User user)
        {
            if (del != null)
            {
                List<VenteMedi> listv = VenteMediDao.GetVenteMediByMedicament(del).ToList();
                List<StockMedi> lists = StockMediDao.GetStockMediByMedicament(del).ToList();
                if (listv.Count == 0 && lists.Count == 0)
                {

                    Medicament m = MedicamentDao.DeleteMedicament(del);
                    if (m == null)
                    {
                        logger.Info(user.Login + " a supprime le medicament {" + m.LibelleMedicament + "," + m.Prix + "," + m.CodeFamille + "}" );
                        return null;
                    }
                    return del;
                }
            }
            return del;
        }

        public Medicament EditMedicament(Medicament m, User user)
        {
            if (m != null)
            {
                if (MedicamentDao.GetMedicamentByLibelle(m.LibelleMedicament) == null)
                {
                    Medicament o = MedicamentDao.EditMedicament(m);
                    if (o != null)
                    {
                        logger.Info(user.Login + " a modifier le medicament de {" + m.LibelleMedicament+","+m.Prix+","+m.CodeFamille+"} a {"+o.LibelleMedicament + "," + o.Prix + "," + o.CodeFamille + "}");
                        return o;
                    }
                }
            }

            return null;
        }

        public IEnumerable<Medicament> GetAll()
        {
            return MedicamentDao.GetAll();
        }

        public IEnumerable<Medicament> GetMedicamentByFamille(Famille f)
        {
            if (f != null)
                return MedicamentDao.GetMedicamentByFamille(f);
            return null;
        }

        public Medicament GetMedicamentByLibelle(string l)
        {
            if (!l.Equals(""))
                return MedicamentDao.GetMedicamentByLibelle(l);
            return null;
        }

        public Medicament GetOneMedicamentById(int id)
        {
            if (id > 0)
                return MedicamentDao.GetOneMedicamentById(id);
            return null;
        }

        public IEnumerable<Medicament> GetMedicamentByMC(string mc)
        {
            return MedicamentDao.GetMedicamentByMC(mc);
        }
    }
}
