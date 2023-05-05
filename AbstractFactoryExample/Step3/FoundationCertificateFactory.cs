using AbstractFactoryExample.Step1;
using AbstractFactoryExample.Step1.ConcreteClasses;
using AbstractFactoryExample.Step1.Interfaces;
using AbstractFactoryExample.Step2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.Step3
{
    internal class FoundationCertificateFactory : IAbstractCertificateFactory
    {
        public ICSharp CreateCSharpCertificate()
        {
            return new CSharpFoundation();
        }

        public IJava CreateJavaCertificate()
        {
            return new JavaFoundation();
        }
    }
}
