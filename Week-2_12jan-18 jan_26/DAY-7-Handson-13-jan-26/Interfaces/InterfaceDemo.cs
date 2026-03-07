using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Interfaces
{
   // internal class InterfaceDemo
   // {
            interface Inter1
            {
                void f1();
            }

            interface Inter2
            {
                void f1();
            }

            class c3 : Inter1, Inter2
            {
               
                void Inter1.f1()
                {
                    Console.WriteLine("This is overiding function of inter1 and inter2 interfaces");
                }

                void Inter2.f1()
                {
                    Console.WriteLine("This is overiding function of inter1 and inter2 interfaces");
                }
            }

           
        }
   // }

    
