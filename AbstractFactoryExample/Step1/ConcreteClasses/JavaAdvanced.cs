using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.Step1.Interfaces;

namespace AbstractFactoryExample.Step1.ConcreteClasses
{
    internal class JavaAdvanced : IJava
    {

        public override string ToString()
        {
            return "I am a Java Advanced Certificate";
        }
    }
}
