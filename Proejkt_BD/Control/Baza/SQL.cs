using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejkt_BD.Control.Baza
{
    class SQL
    {
		public static IQueryable<PERSONEL> CheckLog(string login, string password)
			{
			LINQDataContext db = new LINQDataContext();
			var result = from log in db.PERSONEL
						 where log.login == login &&
						 log.password == password &&
						 log.active == "T"
						 select log;
			return result;
			}

	}
}

