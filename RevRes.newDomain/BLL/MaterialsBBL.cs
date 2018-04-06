using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevRes.Domain.Infrastructure;
using RevRes.Domain.Models;

namespace RevRes.Domain.BLL
{
    public class MaterialBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<Material> GetAll()
        {
            return db.Materials.ToList();
        }

        public static Material SearchByName(string name)
        {
            return db.Materials.FirstOrDefault(m => m.Name == name);
        }
    }
}

