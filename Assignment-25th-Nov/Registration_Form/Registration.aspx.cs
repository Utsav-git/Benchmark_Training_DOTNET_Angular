using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txt_box_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int length = args.Value.Length;
            if (length >= 8 && length <= 15) { 
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}