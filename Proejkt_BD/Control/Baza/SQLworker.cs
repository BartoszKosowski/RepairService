using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejkt_BD.Control.Baza
{
    class SQLworker
    {
		public static IQueryable<ACTIVITY> SearchActivity(string status, string date, string id_worker)
		{
			
			if (date == "" && id_worker =="")
			{
				LINQDataContext db = new LINQDataContext();
				var result = from adm in db.ACTIVITY
							 where adm.status.StartsWith(status) 
							 select adm;
				return result;
			}

			else if (date == "" && id_worker != "")
            {
				LINQDataContext db = new LINQDataContext();
				var result = from adm in db.ACTIVITY
							 where adm.status.StartsWith(status) &&
								adm.id_personel.Equals(id_worker)
							 select adm;
				return result;
			}

			else if (date != "" && id_worker == "")
			{
				LINQDataContext db = new LINQDataContext();
				var result = from adm in db.ACTIVITY
							 where adm.status.StartsWith(status) &&
								adm.date_reg.Equals(date)
							 select adm;
				return result;
			}

			else
			{
				LINQDataContext db = new LINQDataContext();
				var result = from adm in db.ACTIVITY
							 where adm.status.StartsWith(status) &&
								adm.date_reg.Equals(date) &&
								adm.id_personel.Equals(id_worker)
							 select adm;
				return result;
			}

			
		}
	}
}
