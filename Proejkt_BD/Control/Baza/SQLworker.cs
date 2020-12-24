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

            if (date == "" && id_worker == "")
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

        public static void EditActivity(string id, DateTime final, string status, string result)
        {
            //Create new Employee
            LINQDataContext db = new LINQDataContext();
            ACTIVITY Act = db.ACTIVITY.First(e => e.id_activity.Equals(id));
            Act.date_fn_cn = final;
            Act.status = status;
            Act.result = result;

            //Edit Activity to database
            db.SubmitChanges();

            return;
        }

        public static void SetWorkerActive(Int32 id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = (from e in db.PERSONEL
                          where e.id_personel.Equals(id)
                          select e).SingleOrDefault();
            result.active = "T";
            db.SubmitChanges();
        }

        public static void SetWorkerInactive(Int32 id)
        {
            LINQDataContext db = new LINQDataContext();
            var result = (from e in db.PERSONEL
                          where e.id_personel.Equals(id)
                          select e).SingleOrDefault();
            result.active = "F";

            db.SubmitChanges();
        }
    }
}
