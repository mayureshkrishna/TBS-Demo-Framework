﻿using System.Web;
using System.Web.Mvc;

namespace TBS_Demo_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
