﻿using System.Web;
using System.Web.Mvc;

namespace Site_Managment_Re_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
