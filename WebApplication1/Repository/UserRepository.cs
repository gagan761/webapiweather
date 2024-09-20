using Dapper;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Repository

{

    //public class Order
    //{
    //    public string employee_name { get; set; }
    //    public int salary { get; set; }

    //}

    //public class Order
    //{
    //    public int OrderID { get; set; }
    //    public string cc { get; set; }
    //    public DateTime OrderDate { get; set; }
    //    public decimal TotalAmount { get; set; }
    //}

    public class Order
    {
        public int OrderID { get; set; }

        [JsonProperty("CustomerName")]
        public string cc { get; set; }

        [JsonProperty("OrderDate")]
        public DateTime Od { get; set; }

        [JsonProperty("TotalAmount")]
        public decimal tm { get; set; }
    }
    public class TrainingData
    {
        public string TrainingName { get; set; }
        public string TrainingSlot { get; set; }
        public string TrainingCountry { get; set; }
        public string TaxType { get; set; }
    }

    public class UserRepository
    {

        //private readonly IDbConnection _dbConnection;

        public UserRepository()
        {
            
            GetUser();
        }

        public void GetUser()
        {
            string connectionString = "Server=localhost;Database=EmployeeDB;User Id=sa;Password=9934@Dockersql;";

            using (IDbConnection db = new SqlConnection(connectionString))
            {

                //var trainingData = new TrainingData
                //{
                //    TrainingName = "Advanced C#",
                //    TrainingSlot = "Morning",
                //    TrainingCountry = "USA",
                //    TaxType = "Business"
                //};

                // Step 2: Serialize the object to JSON format
                // string jsonTrainingData = JsonConvert.SerializeObject(trainingData);



                //var startDate = new DateTime(2024, 02, 01);
                //var endDate = new DateTime(2024, 03, 31);

                //var parameters = new DynamicParameters();
                //parameters.Add("@StartDate", startDate);
                //parameters.Add("@EndDate", endDate);

                //string storedProcedure = "GetOrdersByDateRange";
                //string query = "SELECT * from employees";

                //IEnumerable<Order> orders = db.Query<Order>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                //foreach (var order in orders)
                //{
                //    Console.WriteLine($"OrderID: {order.OrderID}, Customer: {order.cc}, Date: {order.Od.ToShortDateString()}, Total: {order.tm}");
                //}

                //var inputNumber = 5;
                //var parameters = new DynamicParameters();

                //parameters.Add("@InputNumber", inputNumber, DbType.Int32, ParameterDirection.Input);
                //parameters.Add("@Square", dbType: DbType.Int32, direction: ParameterDirection.Output);

                //db.Execute("CalculateSquare", parameters, commandType: CommandType.StoredProcedure);

                //var squareResult = parameters.Get<int>("@Square");
                //Console.WriteLine($"The square of {inputNumber} is {squareResult}");


                var length = 5.5m;
                var width = 3.2m;

                var query = "SELECT dbo.CalculateRectangleArea(@Length, @Width) AS Area";

                var area = db.QuerySingle<decimal>(query, new { Length = length, Width = width });

                Console.WriteLine($"The area of the rectangle is {area}");

            }
        }
    }
}


//var parameters = new DynamicParameters();
//parameters.Add("@TrainingData", jsonTrainingData, DbType.String);

//// Step 5: Execute the stored procedure
//var result = db.Query("ProcessTrainingData", parameters, commandType: CommandType.StoredProcedure);

//// Output the result
//foreach (var row in result)
//{
//    Console.WriteLine($"TrainingName: {row.TrainingName}, TrainingSlot: {row.TrainingSlot}, " +
//                      $"TrainingCountry: {row.TrainingCountry}, TaxType: {row.TaxType}");
//}