using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class MaasBLL
    {
        public static MaasDTO GetALL()
        {
            MaasDTO dto = new MaasDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.PersonelGetir();
            dto.Aylar = MaasDAO.AylarGetir();
            dto.Maaslar = MaasDAO.MaasGetir();
            return dto;
        }

        public static void MaasEkle(MAA maas)
        {
            MaasDAO.MaasEkle(maas);
        }

        public static void MaasGuncelle(MaasDetayDTO maas, bool control)
        {
            MaasDAO.MaasGuncelle(maas);
            if (control)
                PersonelDAO.PersonelMaasGuncelle(maas);
        }
    }
}
