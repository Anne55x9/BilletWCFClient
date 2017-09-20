using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {

            using(var client = new BilletReferenceService.BilletServiceClient("BasicHttpBinding_IBilletService"))
            {
                
                Console.WriteLine(client.GetPrisBilMedBrobizz());

                Console.ReadLine();
            }

        }
    }
}
