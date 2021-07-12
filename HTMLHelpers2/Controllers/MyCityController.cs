using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers2.ViewModel;
using HTMLHelpers2.Models;
using System.Text;
namespace HTMLHelpers2.Controllers
{
    public class MyCityController : Controller
    {
        // GET: MyDB
        [HttpGet]
        public ActionResult MyListBox()
        {
            //from CityModel1.Context.cs
            MyDBEntities1 cc = new MyDBEntities1();   //using DBContext

            //creating list object of select list item
            //list of select list item
            List<SelectListItem> lsli = new List<SelectListItem>();
            //apply foreach loop
            foreach(City i in cc.Cities)
            {
                //create instance of select list item object
                SelectListItem sli = new SelectListItem()
                {
                    //using text and value property
                    Text = i.Mname,
                    Value = i.Id.ToString(),
                    
                   
                };
                //select list item object sl and add to this collection
               lsli.Add(sli);
            }
            //create an object of CityView
            CityView cv = new CityView();
            cv.Cities =lsli.Select(x=>x.Text);      // as list<select list item>is of I enumrable type
            cv.SelectCities = lsli;
            return View(cv);
            //now first write code in MyListBox.cshtml
        }
        //now we will create post method to send the data
        [HttpPost]
        public string MyListBox(IEnumerable<string> selectCities) //selectCitites property is going to recieve ID
            //make return type as string
        {
            if (selectCities == null)
            {
                return "city is not selected";
            }
            else
            {
                //create instance of String Builder class
                StringBuilder sb = new StringBuilder();
                sb.Append("city selected" + selectCities); //selectCities by id
                //now return String Builder after converting into string
                return sb.ToString();
            }
            
        }
    }
}
/*To avoid string replacing, appending, removing or inserting new strings in the initial string C# introduce StringBuilder concept.
 * StringBuilder is a dynamic object.
 * It doesn’t create a new object in the memory but dynamically expands the needed memory to accommodate the modified or new string.
 * */