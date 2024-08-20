using System;
using System.Diagnostics;

namespace ScaleOutTestWebApi
{
    public partial class init : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("init::Page_Load - Start");
            System.Threading.Thread.SpinWait(10000);
            Debug.WriteLine("init::Page_Load - End");
        }
    }
}