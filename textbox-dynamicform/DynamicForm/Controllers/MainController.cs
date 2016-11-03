using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicForm.Models;

namespace DynamicForm.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            var initialData = new[]
            {
                new Gift {Name = "Tall Hat", Price = 39.95},
                new Gift {Name = "Long Cloak", Price = 120.00},
                new Gift {Name = "New gift", Price = 2.50},
            };
            return View(initialData);
        }

        [HttpPost]
        public ActionResult Index(IEnumerable<Gift> gifts)
        {
			Gift gifts = new Gift();
            string test = "";
			test = String.Join(",", activites.Select(x => x.ACTIVITE_PRINCIPALES));
            gifts.Name = test;//raha ohatra ka le Name fotsiny no considerena eto
            db.Gift.Add(gifts);//exemple fotsiny io pour dire hoe manana table Gift sy attribut Name de Price any @base de données 
            db.SaveChanges();
            return View("Gifts", gifts);
        }
		
		public ActionResult EditGift(short id)
        {
			Gift gifts = db.Gift.Find(id);
            string value = gifts.Name;//ohatra le Name no raisina exemple
            List<String> gifte;
            gifte = value.Split(',').ToList();
            foreach(var item in gifte){
                var currentData = new[] { 
                    new ACTIVITES_POSTE { ACTIVITE_PRINCIPALES = item },//ETO ZAH NO MANANA TSY HITAKO NY HEVITRA HI-CREER-NA ANLEH VUE.
                };
            }
            return View(activite);
		}
        public ActionResult BlankEditorRow()
        {
            return View("GiftEditorRow", new Gift());
        }
    }
}