using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejkt_BD.Control.Baza
{
    class SQLmanager
    {
		public static IQueryable<CLIENT> SearchCustomers(string name, string fname, string lname)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.CLIENT
						 where adm.name.StartsWith(name) &&
							adm.first_name.StartsWith(fname) &&
							adm.last_name.StartsWith(lname)
						 select adm;
			return result;
		}

		public static void AddCustomer(string name, string fname, string lname, string tel)
		{
			//Create new Employee
			LINQDataContext db = new LINQDataContext();
			CLIENT newClient = new CLIENT();
			newClient.name = name;
			newClient.first_name = fname;
			newClient.last_name = lname;
			newClient.tel = tel;

			//Add new Customer to database
			db.CLIENT.InsertOnSubmit(newClient);

			//Save changes to Database.
			db.SubmitChanges();
			return;
		}

		public static void EditCustomer(string id, string name, string fname, string lname, string tel)
		{
			//Edit
			LINQDataContext db = new LINQDataContext();
			CLIENT newClient = db.CLIENT.First(e => e.id_client.Equals(id));
			newClient.name = name;
			newClient.first_name = fname;
			newClient.last_name = lname;
			newClient.tel = tel;


			//Save changes to Database.
			db.SubmitChanges();
			return;
		}

		public static void DeleteCustomer(string id)
		{
			LINQDataContext db = new LINQDataContext();
			//Get customer to Delete
			CLIENT delClient = db.CLIENT.First(e => e.id_client.Equals(id));

			//Delete Employee
			db.CLIENT.DeleteOnSubmit(delClient);

			//Save changes to Database.
			db.SubmitChanges();
		}

		public static IQueryable<OBJECT> SearchObjects(string nr, string name, string type)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.OBJECT
						 where adm.nr_object.StartsWith(nr) &&
							adm.name.StartsWith(name) &&
							adm.obj_type.StartsWith(type)
						 select adm;
			return result;
		}
		public static IQueryable<OBJECT> SearchObjects2(string id)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.OBJECT
						 where adm.id_client.Equals(id)
						 select adm;
			return result;
		}

		public static IQueryable<OBJ_TYPE> SearchObjType(string type)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.OBJ_TYPE
						 where adm.type.Equals(type)
						 select adm;
			return result;
		}

		public static IQueryable<CLIENT> SearchClient(string id)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.CLIENT
						 where adm.id_client.Equals(id)
						 select adm;
			return result;
		}


		public static void AddObject(string nr, string name, string id, string type)
		{
			//Create new Employee
			LINQDataContext db = new LINQDataContext();
			OBJECT newObject = new OBJECT();
			newObject.nr_object = nr;
			newObject.name = name;
			
			//newObject.id_client = id;
			//newObject.obj_type = type;

			//Add new Customer to database
			db.OBJECT.InsertOnSubmit(newObject);

			//Save changes to Database.
			db.SubmitChanges();
			return;
		}

	}
}

