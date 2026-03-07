using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqPractise
{
    internal class LINQ
    {
        
            public static void ReadXmlWithLinq()
            {
                XDocument doc = XDocument.Load(
                    "D:\\Capegemini_CU_Sec3_.NetwithAzzure_Priti\\Week-3_19jan-25jan_26\\23-Jan-26-Handson-Linq-Lambda\\LinqPractise\\XMLFile1.xml"
                );

                var result =
                    from s in doc.Descendants("Student")
                    where (int)s.Element("Marks") > 70
                    select new
                    {
                        Id = (int)s.Element("Id"),
                        Name = (string)s.Element("Name"),
                        Marks = (int)s.Element("Marks")
                    };

                foreach (var student in result)
                {
                    Console.WriteLine($"{student.Id} {student.Name} {student.Marks}");
                }
            }
        }
    }
