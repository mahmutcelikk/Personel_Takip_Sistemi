using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using DAL.DAO;

namespace BLL
{
    public class PersonelBLL
    {
        public static PersonelDTO GetAll()
        {
            PersonelDTO dto = new PersonelDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir().ToList<DAL.POZİSYON>();
            return dto;
        }
    }
}
