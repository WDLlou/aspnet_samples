﻿using System.Web;
using System.Web.Mvc;

namespace WebAPI_Test_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}