using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace CosmosDB
{
    public class CosmoDBOperations
    {
        string CosmoDBuri = ConfigurationManager.AppSettings["Uri"];
        string Keys = ConfigurationManager.AppSettings["PrimaryKey"];
        CosmosClient client = null;
        Container container = null;
        

        public CosmoDBOperations()
        {
            client = new CosmosClient(CosmoDBuri, Keys);
            container = client.GetContainer("azure-dev-cosmo", "employees");
        }

        public async Task AddEmployeesToCosmos()
        {
            EmployeeDataPopulations employeeDataPopulations = new EmployeeDataPopulations();

            foreach (var employee in employeeDataPopulations.GetEmployees())
            {
                try
                {
                    var response = await container.CreateItemAsync<Employee>(employee);
                    Console.WriteLine($"Log: {response.Resource.EmployeeID} created sucessfully");
                }
                catch (CosmosException cex)
                {
                    Console.WriteLine($"Cosmos Exception: {cex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        public async Task GetEmployeeCollectionsFromCosmos()
        {

            QueryDefinition queryDefinition = new QueryDefinition("Select * from c");
            var collections = container.GetItemQueryIterator<Employee>(queryDefinition);

            while (collections.HasMoreResults)
            {
                var employee = await collections.ReadNextAsync();
                foreach (var empl in employee)
                {
                    Console.WriteLine($"ID: {empl.EmployeeID}");
                    Console.WriteLine($"Name: {empl.EmployeeName.ToString()}");
                    Console.WriteLine($"Current Address: {empl.PresentAddress.ToString()}");
                    Console.WriteLine($"Employment Type: {empl.EmploymentType}");
                    Console.WriteLine($"DOJ: {empl.DateJoined.ToString()}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
