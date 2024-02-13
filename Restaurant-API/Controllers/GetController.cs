using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using static Restaurant_API.Helper.Helper;
using Microsoft.Extensions.Configuration;


namespace Restaurant_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        #region View Get All Employees
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllEmployees()
        {
            string query = "SELECT * FROM GET_ALL_EMPLOYEES";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion

        #region View Get All Items
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllItems()
        {
            string query = "SELECT * FROM GET_ALL_ITEMS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion

        #region View Get All Meals
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllMeals()
        {
            string myDb1ConnectionString = _configuration.GetConnectionString("myDb1");
            string query = "SELECT * FROM GET_ALL_MEALS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion

        #region View Get All Orders
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllOrders()
        {
            string query = "SELECT * FROM GET_ALL_ORDERS";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion

        #region View Get Top 10 Orders
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetTopSalesOrders()
        {
            string query = "SELECT * FROM TopSalesOrdersView";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion

        #region View Get Last 20 Orders
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetLastSoldOrders()
        {
            string query = "SELECT * FROM LastSoldOrdersView";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion

        #region  Get Orders Sales Between Date 
        [HttpGet]
        [Route("[action]")]

        public IActionResult GetOrdersSalesBetweenDate(DateTime startDate, DateTime endDate)
        {
            string proc = "GET_SALES_BETWEEN_DATES";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@start_date", startDate);
            command.Parameters.AddWithValue("@end_date", endDate);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return Ok(dataTable);
        }
        #endregion
    }


}
