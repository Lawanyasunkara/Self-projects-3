using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace section3project
{
    public partial class SubjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<subjectss> products = new List<subjectss>();
            products = b.GetProducts1();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }
    }
}