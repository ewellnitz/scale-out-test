using System;
using System.Diagnostics;

namespace ScaleOutTest
{
    public partial class init : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("init::Page_Load - Start");
            System.Threading.Thread.Sleep(5000);
            Debug.WriteLine("init::Page_Load - End");
        }
    }
}