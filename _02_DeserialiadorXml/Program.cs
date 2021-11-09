using System;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;


namespace _02_DeserialiadorXml
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader stream = new StreamReader(@"C:\Users\Heriberto\source\repos\Serializar\serializado1.xml");
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine("Nome : " +usuario.Nome  +"Cpf: "+usuario.CPF  +" Email: " +usuario.Email);
            Console.ReadKey();
        }
    }
}
