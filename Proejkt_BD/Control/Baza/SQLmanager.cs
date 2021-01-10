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
        public static IQueryable<CLIENT> SearchCustomers(object id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.CLIENT
                          where e.id_client.Equals(id)
                          select e;
            return result;
        }


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


		public static void AddObject(string nr, string name, Int32 id, string type)
		{
			//Create new Employee
			LINQDataContext db = new LINQDataContext();
			OBJECT newObject = new OBJECT();
			newObject.nr_object = nr;
			newObject.name = name;			
			newObject.id_client = id;
			newObject.obj_type = type;

			//Add new Customer to database
			db.OBJECT.InsertOnSubmit(newObject);

			//Save changes to Database.
			db.SubmitChanges();
			return;
		}

        public static IQueryable<REQUEST> SearchRequests()
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.REQUEST
                         select e;
            return result;
        }

		public static IQueryable<REQUEST> SearchRequests(string status, string date, string nr_object)
		{
			if (string.IsNullOrWhiteSpace(date))
			{
				LINQDataContext db = new LINQDataContext();
                if(status != "ALL")
                {
                    var result = from adm in db.REQUEST
                                 where adm.status.StartsWith(status) &&
                                    adm.nr_object.StartsWith(nr_object)
                                 select adm;
                    return result;
                }
                else
                {
                    var result = from e in db.REQUEST
                                 select e;
                    return result;
                }
				
			} else if(status == "ALL")
            {
                LINQDataContext db = new LINQDataContext();
                var result = from e in db.REQUEST
                             where e.date_reg.Equals(date)
                             select e;
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

        public static IQueryable<string> SearchActivityDictionary(string act_name)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from adm in db.ACT_DICT
                         where adm.act_name.Equals(act_name)
                         select adm.act_type;
            return result;
        }

        public static IQueryable<string> GetAllObjectTypes()
        {
			LINQDataContext db = new LINQDataContext();
			var result = from types in db.OBJ_TYPE 
						select types.name;
			return result;
		}
        public static IQueryable<string> SearchObjectTypeFromName(string name)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from adm in db.OBJ_TYPE
                         where adm.name.Equals(name)
                         select adm.type;
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
            var result = from e in db.CLIENT
                         where e.id_client.Equals(id)
                         select e;
            return result;
        }

        public static IQueryable<OBJECT> ChooseObject(object id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.OBJECT
                         where e.nr_object.Equals(id)
                         select e;
            return result;
        }

        public static IQueryable<OBJECT> GetCustomerObject(object id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.OBJECT
                         where e.id_client.Equals(id)
                         select e;
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
            activity.status = "ACT";

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
            var result0 = from e in db.PERSONEL
                          where e.id_personel.Equals(Int32.Parse(id))
                          select e.first_name;
            var result1 = from e in db.PERSONEL
                          where e.id_personel.Equals(Int32.Parse(id))
                          select e.last_name;
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

        public static void FulfillRequestInformation(Int32 idre ,string desc, string stat, string resu, DateTime datr, DateTime datf, Int32 idpe, string nrob)
        {
            LINQDataContext db = new LINQDataContext();
            REQUEST request = (from e in db.REQUEST 
                              where e.id_request.Equals(idre)
                              select e).SingleOrDefault();
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
            var number = GetRequestId();
            var requests = from e in db.REQUEST
                           where e.id_request.Equals(number)
                           select e;

            foreach (var request in requests)
                db.REQUEST.DeleteOnSubmit(request);

            db.SubmitChanges();
        }

        public static void DeleteRequestsActivity(Int32 id)
        {
            LINQDataContext db = new LINQDataContext();
            var activityToDelete = from e in db.ACTIVITY
                                   where e.id_request == id
                                   select e;
            foreach (var activity in activityToDelete)
                db.ACTIVITY.DeleteOnSubmit(activity);

            db.SubmitChanges();
        }

        public static IQueryable<string> GetAvailableActivity()
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.ACT_DICT
                         select e.act_name;
            return result;
        }

        public static void RefreshRequest()
        {
            LINQDataContext db = new LINQDataContext();
            db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, db.REQUEST);
        }

        /*public static void GetAvailableWorkers(out IQueryable<string> firstName, out IQueryable<string> lastName) //tak powinno byc ale nie dziala
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.PERSONEL
                         where e.active.ToString().Equals("T") && e.role.ToString().Equals("Worker")
                         select new 
                         {
                             firstName = e.first_name,
                             lastName = e.last_name
                         };
        }*/

        public static IQueryable<string> GetAvailableWorkers()//w tym wypadku jesli bdmy mieli 2 pracownikow o tym samym nazwisku to nwmy ktorego wybieramy
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.PERSONEL
                         where e.active.ToString().Equals("T") && e.role.ToString().Equals("Worker")
                         select e.last_name;

            return result;
        }
        public static void UpdateActivity(Int32 id, Int32 sn, string dc, string wo, string status)
        {
            //Int32 _idPersonel = 0;
            LINQDataContext db = new LINQDataContext();
            var result = (from e in db.ACTIVITY
                          where e.id_request.Equals(id) && e.sequence_nb.Equals(sn)
                          select e).SingleOrDefault();
            var result1 = (from e in db.PERSONEL
                          where e.last_name.ToString().Equals(wo)
                          select e).SingleOrDefault();

            result.id_personel = result1.id_personel;
            result.description = dc;
            result.status = status;


            db.SubmitChanges();
        }

        public static void SaveRequestDetails(Int32 id, string desc, string status, string result, DateTime expDate)
        {
            LINQDataContext db = new LINQDataContext();
            REQUEST request = (from e in db.REQUEST
                               where e.id_request.Equals(id)
                               select e).SingleOrDefault();
            request.description = desc;
            request.status = status;
            request.result = result;
            request.date_reg = expDate;

            db.SubmitChanges();
        }

        public static int GetActivityNumber(Int32 id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = from e in db.ACTIVITY
                         where e.id_request.Equals(id)
                         select e;
            return result.Count() + 1;
        }

    }
}

