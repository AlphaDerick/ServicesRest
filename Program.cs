using System;
using ServicesExtends.Models;
using ServicesExtends;

namespace TestServices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get
             var result = Directory.DIRECTORY_BOOK_BTC_MXN.ServiceGet<RootObject<PayloadOnly>>();
             Console.WriteLine(result.Model.payload.ToString());
            
            //Post
             var user = new Usuario("Vainilla", "fail");
             var tem = user.ServicePost<Respuesta<InfoUsuarioModel>, Usuario>(Directory.DIRECTORY_LOGIN);


             Console.Read();

        }
    }
}
