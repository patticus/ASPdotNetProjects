﻿using System.Web;
using System.Web.Mvc;

namespace Chapter3_Views
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
