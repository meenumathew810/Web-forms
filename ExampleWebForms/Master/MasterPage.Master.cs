﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExampleWebForms.Master
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public string Label { get { return Label1.text; } set { Label1.text = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}