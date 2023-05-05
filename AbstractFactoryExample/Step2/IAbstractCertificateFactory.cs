using AbstractFactoryExample.Step1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.Step2
{
    internal interface IAbstractCertificateFactory
    {
        IJava CreateJavaCertificate(); //Constructor method
        ICSharp CreateCSharpCertificate(); //Constructor method
    }
}
