using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proejkt_BD.Control.Baza.Modele;

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
		public static IQueryable<OBJECT> SearchObjects2(string id) //po id klienta
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.OBJECT
						 where adm.id_client.Equals(id)
						 select adm;
			return result;
		}

		public static IQueryable<OBJECT> SearchObjects3(string id) //po numerze rej
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.OBJECT
						 where adm.nr_object.Equals(id)
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

		public static IQueryable<CLIENT> SearchCustomerFromID(string id)
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

		public static IQueryable<REQUEST> SearchRequests(string status, string date, string nr_object)
		{
			if (string.IsNullOrWhiteSpace(date))
			{
				LINQDataContext db = new LINQDataContext();
				var result = from adm in db.REQUEST
							 where adm.status.StartsWith(status) &&
								adm.nr_object.StartsWith(nr_object)
							 select adm;
				return result;
			}
			else
            {
				LINQDataContext db = new LINQDataContext();
				var result = from adm in db.REQUEST
							 where adm.status.StartsWith(status) &&
								adm.date_reg.Equals(date) &&
								adm.nr_object.StartsWith(nr_object)
							 select adm;
				return result;
			}

		}

		public static IQueryable<ACTIVITY> SearchActivity(string id)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from adm in db.ACTIVITY
						 where adm.id_request.Equals(id)
						 select adm;
			return result;
		}

		public static IQueryable<OBJ_TYPE> GetAllObjectTypes()
        {
			LINQDataContext db = new LINQDataContext();
			var result = from types in db.OBJ_TYPE select types;
			return result;
		}

		public static void AddVehicle(string nr_object, string name , string obj_type, int id_client)
		{
			//Create new Employee
			LINQDataContext db = new LINQDataContext();
			OBJECT newVehicle = new OBJECT();
			newVehicle.nr_object = nr_object;
			newVehicle.name = name;
			newVehicle.obj_type = obj_type;
			newVehicle.id_client = id_client;
			
			//Add new Customer to database
			db.OBJECT.InsertOnSubmit(newVehicle);

			//Save changes to Database.
			db.SubmitChanges();		  
		}
		public static IQueryable<CLIENT> GetAllClients()
		{
			LINQDataContext db = new LINQDataContext();
			var result = from clients in db.CLIENT select clients;
			return result;
		}
		public static IQueryable<ObjectFull> GetObjectFull(string nr, string name, string type)
        {
			LINQDataContext db = new LINQDataContext();
			var result = from objects in db.OBJECT
						 join clients in db.CLIENT on objects.id_client equals clients.id_client
						 join types in db.OBJ_TYPE on objects.obj_type equals types.type
						 where objects.nr_object.Contains(nr) &&
							objects.name.Contains(name) &&
							objects.obj_type.Contains(type)
						 select new ObjectFull
						 {
							 client_name = clients.name,
							 name = objects.name,
							 nr_object = objects.nr_object,
							 type_name = types.name
						 };
			return result;
		}

		public static IQueryable<ObjectFull> GetSingleObjectFull(string nr)
		{
			LINQDataContext db = new LINQDataContext();
			var result = from objects in db.OBJECT
						 join clients in db.CLIENT on objects.id_client equals clients.id_client
						 join types in db.OBJ_TYPE on objects.obj_type equals types.type
						 where objects.nr_object == nr
						 select new ObjectFull
						 {
							 client_name = clients.name,
							 name = objects.name,
							 nr_object = objects.nr_object,
							 type_name = types.name
						 };
			return result;
		}

        public static IQueryable<CLIENT> ChooseCustomer(object id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from cc in db.CLIENT
                         where cc.id_client.Equals(id)
                         select cc;
            return result;
        }

        public static IQueryable<OBJECT> ChooseObject(object id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from co in db.OBJECT
                         where co.nr_object.Equals(id)
                         select co;
            return result;
        }

        public static IQueryable<OBJECT> GetCustomerObject(object id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from gco in db.OBJECT
                         where gco.id_client.Equals(id)
                         select gco;
            return result;
        }

        public static void AddActivity(Int32 id, Int32 sn, string ad, string dc, DateTime regDate, DateTime exDate)
        {
            LINQDataContext db = new LINQDataContext();
            ACTIVITY activity = new ACTIVITY();
            activity.id_request = id;
            activity.sequence_nb = sn;
            activity.act_dict = ad ;
            activity.description = dc;
            activity.date_reg = regDate;
            activity.date_fn_cn = exDate;
            activity.status = "Active";

            db.ACTIVITY.InsertOnSubmit(activity);
            db.SubmitChanges();
        }

        public static Int32 GetRequestId()
        {
            int id = 0;
            LINQDataContext db = new LINQDataContext();
            var requestId = from e in db.REQUEST
                               orderby e.id_request descending
                               select e.id_request;
            id = Int32.Parse(requestId.First().ToString());
            return id;
        }

        public static string GetManagerName(string id) //do poprawy
        {
            LINQDataContext db = new LINQDataContext();
            var result0 = from gmn in db.PERSONEL
                          where gmn.id_personel.Equals(Int32.Parse(id))
                          select gmn.first_name;
            var result1 = from gmn in db.PERSONEL
                          where gmn.id_personel.Equals(Int32.Parse(id))
                          select gmn.last_name;
            string name = result0.ToString() + result1.ToString();
            return name;
        }

        public static string GetDefaultVehicle()
        {
            string ss = "";
            LINQDataContext db = new LINQDataContext();
            var defaultVehicle = from e in db.OBJECT
                                 select e.nr_object;
            ss = defaultVehicle.First().ToString();
            return ss;
        }

        public static void CreateEmptyRequest()
        {
            LINQDataContext db = new LINQDataContext();
            REQUEST request = new REQUEST();
            request.id_request = GetRequestId();
            request.description = "";
            request.status = "";
            request.result = "";
            request.date_reg = DateTime.Today;
            request.date_fn_cn = DateTime.Today;
            request.id_personel = 1;
            request.nr_object = GetDefaultVehicle(); // Alles klar

            db.REQUEST.InsertOnSubmit(request);
            db.SubmitChanges();
        }

        public static void FulfillRequestInformation(Int32 idre ,string desc, string stat, string resu, DateTime datr, DateTime datf, Int16 idpe, string nrob)
        {
            LINQDataContext db = new LINQDataContext();
            REQUEST request = (from p in db.REQUEST 
                              where p.id_request.Equals(idre)
                              select p).SingleOrDefault();
            request.description = desc;
            request.status = stat;
            request.result = resu;
            request.date_reg = datr;
            request.date_fn_cn = datf;
            request.id_personel = idpe;
            request.nr_object = nrob;

            db.SubmitChanges();
        }

        public static void DeleteCurrentRequest()
        {
            LINQDataContext db = new LINQDataContext();
            var number = from dcr in db.REQUEST
                         select dcr;
            var requests = from dcr in db.REQUEST
                           where dcr.id_request.Equals(number.Count() - 1)
                           select dcr;

            foreach (var request in requests)
                db.REQUEST.DeleteOnSubmit(request);

            db.SubmitChanges();
        }

        public static void DeleteRequestsActivity(Int32 id)
        {
            LINQDataContext db = new LINQDataContext();
            var activityToDelete = from dra in db.ACTIVITY
                                   where dra.id_request == id
                                   select dra;
            foreach (var activity in activityToDelete)
                db.ACTIVITY.DeleteOnSubmit(activity);

            db.SubmitChanges();
        }

        public static IQueryable<string> GetAvailableActivity()
        {
            LINQDataContext db = new LINQDataContext();
            var result = from gaa in db.ACT_DICT
                         select gaa.act_name;
            return result;
        }
    }
}

