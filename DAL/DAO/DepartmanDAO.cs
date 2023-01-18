using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmanDAO : PersonelDataContext
    {
        public static void DepartmanEkle(DEPARTMAN dpt)
        {

            try
            {
              
                db.DEPARTMANs.InsertOnSubmit(dpt);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public static List<DEPARTMAN> DepartmanGetir()
        {
            try
            {
                return db.DEPARTMANs.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void DepartmanGuncelle(DEPARTMAN dpt)
        {
            try
            {
                DEPARTMAN dp = db.DEPARTMANs.First(x => x.ID == dpt.ID);
                dp.DepartmanAd = dpt.DepartmanAd;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
