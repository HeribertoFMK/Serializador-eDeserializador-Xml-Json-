using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;
namespace _01_SerealizarXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose Marcos", CPF = "222.333.444-55", Email = "Josemarcos@gmail.com" };

            XmlSerializer serializador1 = new XmlSerializer(typeof(Usuario));
            //ou
            XmlSerializer serializador2 = new XmlSerializer(usuario.GetType());

            

            StreamWriter stream1 = new StreamWriter(@"C:\Users\Heriberto\source\repos\Serializar\serializado1.xml");
            StreamWriter stream2 = new StreamWriter(@"C:\Users\Heriberto\source\repos\Serializar\serializado2.xml");
            serializador1.Serialize(stream1, usuario);
            serializador2.Serialize(stream2, usuario);
        }


    }
}
