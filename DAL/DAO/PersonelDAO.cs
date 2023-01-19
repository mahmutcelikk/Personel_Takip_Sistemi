using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DAO
{
    public class PersonelDAO : PersonelDataContext
    {
        public static void PersonelEkle(PERSONEL ps)
        {
            try
            {
                db.PERSONELs.InsertOnSubmit(ps);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PersonelDetay> PersonelGetir()
        {
            List<PersonelDetay> liste = new List<PersonelDetay>();

            var list = (from p in db.PERSONELs
                        join d in db.DEPARTMANs on p.DepartmanID equals d.ID
                        join pz in db.POZİSYONs on p.PozisyonID equals pz.ID
                        select new
                        {
                            personelID = p.ID,
                            departmanID = p.DepartmanID,
                            pozisyonID = p.PozisyonID,
                            pozisyon = pz.PozisyonAd,
                            departman = d.DepartmanAd,
                            isAdmin = p.isAdmin,
                            ad = p.Ad,
                            soyad = p.Soyad,
                            sifre = p.Password,
                            userno = p.UserNo,
                            resim = p.Resim,
                            maas = p.Maas,
                            dogumGunu = p.DogumGunu,
                            adres = p.Adres,

                        }).OrderBy(x => x.personelID).ToList();

            foreach (var item in list)
            {
                PersonelDetay dto = new PersonelDetay();
                dto.PersonelID = item.personelID;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonID = item.pozisyonID;
                dto.PozisyonAd = item.pozisyon;
                dto.DepartmanAd = item.departman;
                dto.isAdmin = item.isAdmin;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.Sifre = item.sifre;
                dto.UserNo = item.userno;
                dto.Resim = item.resim;
                dto.Maas = item.maas;
                dto.DogumTarihi = item.dogumGunu;
                dto.Adres = item.adres;
                liste.Add(dto);
            }

            return liste;
        }

        public static void PersonelSil(int personelID)
        {
            try
            {
                
                PERSONEL per = db.PERSONELs.First(x => x.ID == personelID);
                db.PERSONELs.DeleteOnSubmit(per);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void PersonelGuncelle(PozisyonDetayDTO detay)
        {
            List<PERSONEL> list = db.PERSONELs.Where(x => x.PozisyonID == detay.ID).ToList();
            foreach (var item in list)
            {
                item.DepartmanID = detay.DepartmanID;
            }
            db.SubmitChanges();
        }

        public static void PersonelGuncelle(PersonelDetay ps)
        {
            try
            {
                PERSONEL pr = db.PERSONELs.First(x=>x.ID == ps.PersonelID);
                pr.UserNo = ps.UserNo;
                pr.Ad = ps.Ad;
                pr.Soyad = ps.Soyad;
                pr.Password = ps.Sifre;
                pr.PozisyonID = ps.PozisyonID;
                pr.DepartmanID = ps.DepartmanID;
                pr.Adres = ps.Adres;
                pr.isAdmin = ps.isAdmin;
                pr.Maas = ps.Maas;
                pr.Resim = ps.Resim;
                pr.DogumGunu = ps.DogumTarihi;
                db.SubmitChanges();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void PersonelMaasGuncelle(MaasDetayDTO maas)
        {
            try
            {
                PERSONEL pr = db.PERSONELs.First(x => x.ID == maas.PersonelID);
                pr.Maas = maas.MaasMiktar;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PERSONEL> PersonelGetir(int v, string text)
        {
            return db.PERSONELs.Where(x => x.UserNo == v && x.Password == text).ToList();
            
        }

        public static List<PERSONEL> PersonelGetir(int v)
        {
            return db.PERSONELs.Where(x => x.UserNo == v).ToList();
        }
    }
}
