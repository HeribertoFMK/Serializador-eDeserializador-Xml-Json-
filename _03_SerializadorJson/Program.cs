using _00_Biblioteca;
using Newtonsoft.Json;


using System.IO;


namespace _03_SerializadorJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose feliciano", CPF = "111.333.66655", Email = "Josefeliciano@gmail.com" };

            
            //primeiro metodo
            File.WriteAllText(@"C:\Users\Heriberto\source\repos\Serializar\serial.json", JsonConvert.SerializeObject(usuario));

            //segundo metodo

            using (StreamWriter stream = File.CreateText(@"C:\Users\Heriberto\source\repos\Serializar\serial2.json"))
            {
                JsonSerializer serializando = new JsonSerializer();
                serializando.Serialize(stream, usuario);
                
            }

          
            





            


        }
    }
}
