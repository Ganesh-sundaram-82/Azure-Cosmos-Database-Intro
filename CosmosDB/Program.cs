using System;
using System.Threading.Tasks;

namespace CosmosDB
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Process Started..");

            ////CosmoDBOperations cosmoDBOperations = new CosmoDBOperations();
            ////Console.WriteLine("Insert into Cosmo Database");
            ////Console.WriteLine();
            ////await cosmoDBOperations.AddEmployeesToCosmos();

            ////Console.WriteLine();
            ////Console.WriteLine("******************************************************************");

            ////await cosmoDBOperations.GetEmployeeCollectionsFromCosmos();

            ////Console.WriteLine();
            ////Console.WriteLine("******************************************************************");


            CosmosDB.MongoDB.MongoDBOperations mongoDBOperations = new MongoDB.MongoDBOperations();
            await mongoDBOperations.GetAllDatabases();

            Console.WriteLine("Process Completed..");
            Console.Read();
        }
    }
}
