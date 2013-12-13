using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Collections;
using System.Web.Security;

namespace WebApplication2.Account
{
    public partial class MembersOnly : System.Web.UI.Page
    {
        public Double maxValue1=1000, minValue1=0;
        public Double maxValue2 = 1000, minValue2 = 0;
        public Double maxValue3 = 1000, minValue3 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
           

           Datos m= new Datos();
           Label6.Text = m.strs2[9];
           Label8.Text = m.strs3[9];
           Label10.Text = m.strs4[9];
                       

        }

        
        void sendMail(string subject, string body)
        {


            MembershipUserCollection x = Membership.FindUsersByName(User.Identity.Name);
            MembershipUser y;


            foreach (MembershipUser user in x)
            {
               
                y = user;
                
           


             MailMessage message = new MailMessage("eliguzrd@gmail.com",  y.Email, subject, body);
               SmtpClient emailClient = new SmtpClient("smtp.gmail.com", 587);
                 System.Net.NetworkCredential SMTPUserInfo = new System.Net.NetworkCredential("eliguzrd@gmail.com", "ailiaili");
                emailClient.UseDefaultCredentials = false;
              emailClient.Credentials = SMTPUserInfo;
              emailClient.EnableSsl = true;
                emailClient.Send(message);
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Chart1.Series["Series1"].Points.Dispose();
            Chart2.Series["Series1"].Points.Dispose();
            Chart3.Series["Series1"].Points.Dispose();
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            alarmas1();
            alarmas2();
            alarmas3();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Double.Parse(TextBox1.Text) > Double.Parse(TextBox2.Text))
            {
                Label4.Visible = true;
            }
            else
            {
                minValue1 = Double.Parse(TextBox1.Text);
                maxValue1 = Double.Parse(TextBox2.Text);
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Double.Parse(TextBox5.Text) > Double.Parse(TextBox6.Text))
            {
                Label14.Visible = true;
            }
            else
            {
                minValue2 = Double.Parse(TextBox5.Text);
                maxValue2 = Double.Parse(TextBox6.Text);
            }

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Double.Parse(TextBox5.Text) > Double.Parse(TextBox6.Text))
            {
                Label18.Visible = true;
            }
            else
            {
                minValue3 = Double.Parse(TextBox5.Text);
                maxValue3 = Double.Parse(TextBox6.Text);
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void alarmas1()
        {
            Datos x = new Datos();
            Double valor = Double.Parse(x.strs2[9]);
            Double prev = Double.Parse(x.strs2[8]);
            Label6.Text = x.strs2[9];

            if (valor < minValue1 & prev > minValue1)
            {

                sendMail("Nivel1 muy bajo", "");
            }
            else if (valor > maxValue1 && prev < maxValue1)
            {

                sendMail("Nivel1 alto", "");
            }
            if (valor > minValue1 & prev < minValue1)
            {
                sendMail("Nivel1 bajo regulado", "");

            }
            if (valor < maxValue1 && prev > maxValue1)
            {
                sendMail("Nivel1 alto regulado", "");

            }
        
        }


        void alarmas2()
        {
            Datos x = new Datos();
            Double valor = Double.Parse(x.strs3[9]);
            Double prev = Double.Parse(x.strs3[8]);
            Label8.Text = x.strs3[9];

            if (valor < minValue2 & prev > minValue2)
            {

                sendMail("Nivel2 muy bajo", "");
            }
            else if (valor > maxValue2 && prev < maxValue2)
            {

                sendMail("Nivel2 alto", "");
            }
            if (valor > minValue2 & prev < minValue2)
            {
                sendMail("Nivel2 bajo regulado", "");

            }
            if (valor < maxValue2 && prev > maxValue2)
            {
                sendMail("Nivel2 alto regulado", "");

            }

        }

        void alarmas3()
        {
            Datos x = new Datos();
            Double valor = Double.Parse(x.strs4[9]);
            Double prev = Double.Parse(x.strs4[8]);
            Label10.Text = x.strs4[9];

            if (valor < minValue3 & prev > minValue3)
            {

                sendMail("Nivel3 muy bajo", "");
            }
            else if (valor > maxValue3 && prev < maxValue3)
            {

                sendMail("Nivel3 alto", "");
            }
            if (valor > minValue3 & prev < minValue3)
            {
                sendMail("Nivel3 bajo regulado", "");

            }
            if (valor < maxValue3 && prev > maxValue3)
            {
                sendMail("Nivel3 alto regulado", "");

            }

        }
    


        

    }
}