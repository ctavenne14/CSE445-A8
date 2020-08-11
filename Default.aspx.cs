using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
        string xml = TextBox1.Text;
        string xsd = TextBox2.Text;
        if (!String.IsNullOrWhiteSpace(TextBox1.Text) && !String.IsNullOrWhiteSpace(TextBox2.Text))
        {
            string verify = myClient.Validate(xml, xsd);
            lblUpload.Text = verify;
        }
        else
        {
            lblUpload.Text = "Please enter a valid xml or xsd file in the Text Boxes";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
        string xml = TextBox3.Text;
        string xsl = TextBox4.Text;

        if (!String.IsNullOrWhiteSpace(TextBox3.Text) && !String.IsNullOrWhiteSpace(TextBox4.Text))
        {
            string html = myClient.Transformation(xml, xsl);
            Label1.Text = html;
        }

        else
        {
            Label1.Text = "Please enter a valid xml or xsd file in the Text Boxes";
        }
    }
}