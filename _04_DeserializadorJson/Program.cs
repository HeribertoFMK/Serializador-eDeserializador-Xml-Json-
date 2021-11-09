using _00_Biblioteca;
using Newtonsoft.Json;
using System.IO;



namespace _04_DeserializadorJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //primeiro metodo
            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(File.ReadAllText(@"C:\Users\Heriberto\source\repos\Serializar\serial2.json"));


            System.Console.WriteLine("Usuario: " + usuario.Nome +" Cpf: " + usuario.CPF +" Email: " + usuario.Email);

            //Segundo Metodo
            using (StreamReader stream3 = File.OpenText(@"C:\Users\Heriberto\source\repos\Serializar\serial.json"))
            {
                JsonSerializer serie = new JsonSerializer();
                Usuario usuario1 = (Usuario)serie.Deserialize(stream3, typeof(Usuario));
                System.Console.WriteLine("Usuario: " + usuario1.Nome + " Cpf: " + usuario1.CPF + " Email: " + usuario1.Email);


            }
            



        }
    }

}