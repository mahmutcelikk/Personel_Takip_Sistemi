using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using DAL.DAO;

namespace BLL
{
    public class IsBLL
    {
        public static IsDTO GetAll()
        {
            IsDTO dto = new IsDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.PersonelGetir();
            dto.IsDurumlari = IsDAO.DurumGetir();
            return dto;
        }
    }
}
