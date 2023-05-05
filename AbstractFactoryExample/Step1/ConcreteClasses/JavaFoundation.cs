using AbstractFactoryExample.Step1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.Step1.ConcreteClasses
{
    internal class JavaFoundation : IJava
    {
        public override string ToString()
        {
            return "I am a Java Foundation Certificate";
        }
    }
}
