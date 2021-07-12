using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  HTMLHelpers2.Models;
namespace HTMLHelpers2.ViewModel
{
    public class CityView
    {
        public IEnumerable<string>  Cities { get; set; }  //due to Database created in server explorer
       
        public IEnumerable<SelectListItem> SelectCities{get;set;}    //due to Database created in server explorer, this is an auto implemented property
        //SelectListItem()-Initializes a new instance of the SelectListItem class
        //SelectList-Represents a list that lets users select one item.
    }
}