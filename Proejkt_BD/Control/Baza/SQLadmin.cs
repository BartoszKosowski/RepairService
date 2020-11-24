using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejkt_BD.Control.Baza
{
    class SQLadmin
    {
		public static IQueryable<PERSONEL> SearchAdmin(string fname, string lname, string login, string role, string active)
		{
			LINQDataContext db = new LINQDataContext();
			if (active == "A")
			{
				var result = from adm in db.PERSONEL
							 where adm.first_name.StartsWith(fname) &&
								adm.last_name.StartsWith(lname) &&
								adm.login.StartsWith(login) &&
								adm.role.StartsWith(role) &&
								adm.active.StartsWith("")
							 select adm;
				return result;
			}
			else
			{
				var result = from adm in db.PERSONEL
							 where adm.first_name.StartsWith(fname) &&
								adm.last_name.StartsWith(lname) &&
								adm.login.StartsWith(login) &&
								adm.role.StartsWith(role) &&
								adm.active.StartsWith(active)
							 select adm;
				return result;
			}
		}

		public static void AddPersonel(string fname, string lname, string login, string role, string password, string active)
		{
			//Create new Employee
			LINQDataContext db = new LINQDataContext();
			PERSONEL newPersonel = new PERSONEL();
			newPersonel.first_name = fname;
			newPersonel.last_name = lname;
			newPersonel.login = login;
			newPersonel.password = password;
			newPersonel.role = role;
			newPersonel.active = active;

			//Add new Employee to database
			db.PERSONEL.InsertOnSubmit(newPersonel);

			//Save changes to Database.
			db.SubmitChanges();
			return;
		}
		public static void EditPersonel(string id, string fname, string lname, string password, string active)
		{
			//Create new Employee
			LINQDataContext db = new LINQDataContext();
			PERSONEL Personel = db.PERSONEL.First(e => e.id_personel.Equals(id));
			Personel.first_name = fname;
			Personel.last_name = lname;
			Personel.password = password;
			Personel.active = active;

			//Edit Employee to database
			db.SubmitChanges();

			return;

		}

	}
}
