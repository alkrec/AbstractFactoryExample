// See https://aka.ms/new-console-template for more information

using AbstractFactoryExample.Step1.Interfaces;
using AbstractFactoryExample.Step2;
using AbstractFactoryExample.Step3;

//Create Foundation Certificate Factory
IAbstractCertificateFactory FoundationCertificateFactory = new FoundationCertificateFactory();

//Create CSharp Foundation Certificate
ICSharp CSharpFoundationCertificate = FoundationCertificateFactory.CreateCSharpCertificate();
Console.WriteLine(CSharpFoundationCertificate.ToString());

//Create Java Foundation Certificate
IJava JavaFoundationCertificate = FoundationCertificateFactory.CreateJavaCertificate();
Console.WriteLine(JavaFoundationCertificate.ToString());
