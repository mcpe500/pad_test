using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD_ROTIKITA.Services
{
    public class DatabaseService
    {
        private static db_rotiEntities _dbInstance;

        public static db_rotiEntities GetDbContext()
        {
            if (_dbInstance == null)
            {
                _dbInstance = new db_rotiEntities();
            }
            return _dbInstance;
        }
        public static string PadLeftZero(string text, int num, int maxLength)
        {
            string paddedNum = num.ToString().PadLeft(maxLength - text.Length, '0');
            return $"{text}{paddedNum}";
        }
    }

}
