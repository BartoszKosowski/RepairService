using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejkt_BD.Control.Baza
{
	class SQL
	{

		// PANEL LOGOWANIA \/\/\/
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
		//PANEL LOGOWANIA /\/\/\





		//ADMIN PANEL \/\/\/
		public static IQueryable<PERSONEL> SearchAdmin(string fname, string lname, string login, string role, string active)
		{
				LINQDataContext db = new LINQDataContext();
			var result = from adm in db.PERSONEL
						 where adm.first_name.StartsWith(fname) &&
							adm.last_name.StartsWith(lname) &&
							adm.login.StartsWith(login)  &&
							adm.role.StartsWith(role) &&
							adm.active.StartsWith(active)
						 select adm;
			return result;
			}

		//ADMIN PANEL /\/\/\

	}
}

