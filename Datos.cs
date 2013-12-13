using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.IO;
using System.Globalization;

namespace WebApplication2
{
    public class Datos
    {
       
       public  IList<Punto> analog1 = new List<Punto>();
       public IList<Punto> analog2 = new List<Punto>();
       public IList<Punto> analog3 = new List<Punto>();
       String line;
       public string[] strs1, strs2, strs3, strs4;
       
        
        public Datos()
        {
            lectura();
            
        }


        public IList<Punto> getAnalog1()
        {
            return analog1;
        }
        public IList<Punto> getAnalog2()
        {
            return analog2;
        }
        public IList<Punto> getAnalog3()
        {
            return analog3;
        }
        
        public void lectura()
        {
            //LECTURA HORAS
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\horas.txt"))
                {
                    line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    sr.Close();
                }
                strs1 = line.Split(',');

                //LECTURA ANALOG1
                try
                {
                    using (StreamReader sr = new StreamReader(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\analog1.txt"))
                    {
                        line = sr.ReadToEnd();
                        Console.WriteLine(line);
                        sr.Close();

                    }
                    strs2 = line.Split(' ');

                    //LECTURA ANALOG2
                    try
                    {
                        using (StreamReader sr = new StreamReader(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\analog2.txt"))
                        {
                            line = sr.ReadToEnd();
                            Console.WriteLine(line);
                            sr.Close();

                        }
                        strs3 = line.Split(' ');

                        //LECTURA ANALOG3
                        try
                        {
                            using (StreamReader sr = new StreamReader(@"C:\\Users\\Elizabeth G\\Documents\\Visual Studio 2010\\Projects\\WebApplication2\\WebApplication2\\analog3.txt"))
                            {
                                line = sr.ReadToEnd();
                                Console.WriteLine(line);
                                sr.Close();
                            }
                            strs4 = line.Split(' ');

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ANALOG3:The file could not be read:");
                            Console.WriteLine(e.Message);
                        }
                        /////////////FIN LECTURA ANALOG3
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ANALOG2:The file could not be read:");
                        Console.WriteLine(e.Message);
                    }
                    ///FIN LECTURA ANALOG2
                }
                catch (Exception e)
                {
                    Console.WriteLine("ANALOG1:The file could not be read:");
                    Console.WriteLine(e.Message);
                }
                ///FIN LECTURA ANALOG1   

                for (int i = 0; i < strs1.Length; i++)
                {
                    try
                    {
                        DateTime prueba = DateTime.Parse(strs1[i]);
                        analog1.Add(new Punto { ID = i, time = prueba, value = System.Convert.ToDouble(strs2[i]) });
                        analog2.Add(new Punto { ID = i, time = prueba, value = System.Convert.ToDouble(strs3[i]) });
                        analog3.Add(new Punto { ID = i, time = prueba, value = System.Convert.ToDouble(strs4[i]) });

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("No se convierte correctamente a DateTime");
                        Console.WriteLine(e.Message);
                    }
                }



            }
            catch (Exception e)
            {
                Console.WriteLine("HORAS:The file could not be read:");
                Console.WriteLine(e.Message);
            }
            ///FIN LECTURA HORAS
        }
    }
}