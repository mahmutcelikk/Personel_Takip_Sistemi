using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class IsDAO : PersonelDataContext
    {
        public static List<ISDURUM> DurumGetir()
        {
            return db.ISDURUMs.ToList();
        }

        public static void IsEkle(I iss)
        {
            try
            {
                db.Is.InsertOnSubmit(iss);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<IsDetayDTO> IsGetir()
        {
            List<IsDetayDTO> liste = new List<IsDetayDTO>();
            var list = (from i in db.Is
                        join p in db.PERSONELs on i.PersonelID equals p.ID
                        join d in db.DEPARTMANs on p.DepartmanID equals d.ID
                        join pz in db.POZİSYONs on p.PozisyonID equals pz.ID
                        join durum in db.ISDURUMs on i.IsDurumID equals durum.ID
                        select new
                        {
                            isID = i.ID,
                            baslik = i.Baslik,
                            icerik = i.Icerik,
                            baslamaTarihi = i.IsBaslamaTarihi,
                            bitisTarihi = i.IsBitisTarihi,
                            userNo = p.UserNo,
                            ad = p.Ad,
                            soyad = p.Soyad,
                            departman = d.DepartmanAd,
                            departmanID = p.DepartmanID,
                            pozisyon = pz.PozisyonAd,
                            pozisyonID = p.PozisyonID,
                            isDurum = durum.IsDurumAd,
                            isDurumID = i.IsDurumID,
                            personelID=i.ID,


                        }
                             ).OrderBy(x => x.baslamaTarihi).ToList();

            foreach (var item in list)
            {
                IsDetayDTO dto = new IsDetayDTO();
                dto.IsID = item.isID;
                dto.IsBaslik = item.baslik;
                dto.IsRapor = item.icerik;
                dto.IsBaslamaTarihi = item.baslamaTarihi;
                dto.IsBitisTarihi = item.bitisTarihi;
                dto.UserNo = item.userNo;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.DepartmanAd = item.departman;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonAd = item.pozisyon;
                dto.PozisyonID = item.pozisyonID;
                dto.IsDurum = item.isDurum;
                dto.IsDurumID = item.isDurumID;
                dto.PersonelID = item.personelID;
                liste.Add(dto);
            }
            return liste;   

        }

        public static void IsGuncell(IsDetayDTO dtoo)
        {
            try
            {
                I iss = db.Is.First(x => x.ID == dtoo.IsID);
                iss.Baslik = dtoo.IsBaslik;
                iss.Icerik = dtoo.IsRapor;
                iss.IsDurumID = dtoo.IsDurumID;
                iss.PersonelID = dtoo.PersonelID;
                db.SubmitChanges();
            } 
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
