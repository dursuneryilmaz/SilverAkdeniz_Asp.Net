﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Other : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CompanyDetails comp = new CompanyDetails();
        comp = CatalogAccess.GetCompanyDetails();
        logo.ImageUrl = comp.siteLogo;
        fbAcc.NavigateUrl = comp.fbAccount;
        twAcc.NavigateUrl = comp.twAccount;
        yutbAcc.NavigateUrl = comp.youtAccount;
        instAcc.NavigateUrl = comp.instaAccount;
    }
}
