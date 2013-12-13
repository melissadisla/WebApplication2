using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string toWrite;
        int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            string analog1String = Request.QueryString["x"];
            string analog2String = Request.QueryString["y"];
            string analog3String = Request.QueryString["z"];
            string time = DateTime.Now.TimeOfDay.ToString();
            string[] horas;
            string[] analog1;
            string[] analog2;
            string[] analog3;
            string[] newString;

            time = time.Substring(0, 8);
           
           

            Datos m = new Datos();
            horas = m.strs1;
            analog1 = m.strs2;
            analog2 = m.strs3;
            analog3 = m.strs4;

            counter = horas.Length;

            while (counter > 9)
            {
                horas[0] = horas[1];
                horas[1] = horas[2];
                horas[2] = horas[3];
                horas[3] = horas[4];
                horas[4] = horas[5];
                horas[5] = horas[6];
                horas[6] = horas[7];
                horas[7] = horas[8];
                horas[8] = horas[9];


                analog1[0] = analog1[1];
                analog1[1] = analog1[2];
                analog1[2] = analog1[3];
                analog1[3] = analog1[4];
                analog1[4] = analog1[5];
                analog1[5] = analog1[6];
                analog1[6] = analog1[7];
                analog1[7] = analog1[8];
                analog1[8] = analog1[9];

                analog2[0] = analog2[1];
                analog2[1] = analog2[2];
                analog2[2] = analog2[3];
                analog2[3] = analog2[4];
                analog2[4] = analog2[5];
                analog2[5] = analog2[6];
                analog2[6] = analog2[7];
                analog2[7] = analog2[8];
                analog2[8] = analog2[9];

                
                analog3[0] = analog3[1];
                analog3[1] = analog3[2];
                analog3[2] = analog3[3];
                analog3[3] = analog3[4];
                analog3[4] = analog3[5];
                analog3[5] = analog3[6];
                analog3[6] = analog3[7];
                analog3[7] = analog3[8];
                analog3[8] = analog3[9];
                

                counter--;
            }
            newString = new string[horas.Length + 1];
            for (int i = 0; i < counter; i++)
                newString[i] = horas[i];
            horas = newString;
            horas[counter] = time;

            newString = new string[analog1.Length + 1];
            for (int i = 0; i < counter; i++)
                newString[i] = analog1[i];
            analog1 = newString;
            analog1[counter] = analog1String;

            newString = new string[analog2.Length + 1];
            for (int i = 0; i < counter; i++)
                newString[i] = analog2[i];
            analog2 = newString;
            analog2[counter] = analog2String;


            newString = new string[analog3.Length + 1];
            for (int i = 0; i < counter; i++)
                newString[i] = analog3[i];
            analog3 = newString;
            analog3[counter] = analog3String;
           
            counter++;
            string ruta;

            toWrite = "";
            for (int i = 0; i < counter; i++)
            {
                if (i < counter - 1)
                    toWrite += horas[i] + ",";
                else
                    toWrite += horas[i];
            }
            
            System.IO.File.WriteAllText(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\" +"horas" + ".txt", toWrite);


            ////
            toWrite = "";
            for (int i = 0; i < counter; i++)
            {
                if (i < counter - 1)
                    toWrite += analog1[i] + " ";
                else
                    toWrite += analog1[i];
            }

            System.IO.File.WriteAllText(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\" + "analog1" + ".txt", toWrite);

            ////
            toWrite = "";
            for (int i = 0; i < counter; i++)
            {
                if (i < counter - 1)
                    toWrite += analog2[i] + " ";
                else
                    toWrite += analog2[i];
            }

            System.IO.File.WriteAllText(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\" + "analog2" + ".txt", toWrite);

            ////
            toWrite = "";
            for (int i = 0; i < counter; i++)
            {
                if (i < counter - 1)
                    toWrite += analog3[i] + " ";
                else
                    toWrite += analog3[i];
            }

            System.IO.File.WriteAllText(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\" + "analog3" + ".txt", toWrite);


           

        }



       
        
    }
}