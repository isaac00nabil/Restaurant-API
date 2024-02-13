using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Restaurant_API.DTOs;
using System.Data;
using static Restaurant_API.Helper.Helper;

namespace Restaurant_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        #region Add Employee
        [HttpPost]
        [Route("[action]")]
        public IActionResult AddNewEmployee([FromBody] CreateEmployeesDTO dto)
        {
            string proc = "INSERT_NEW_EMPLOYEE";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@employee_name", dto.EmployeeName);
            command.Parameters.AddWithValue("@employee_password", RandomPassword());
            command.Parameters.AddWithValue("@admin_id", dto.AdminId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Add New Employee Done" : "Failed To Add New Employee");

        }

        #endregion


        #region Add Item
        [HttpPost]
        [Route("[action]")]
        public IActionResult AddNewItem([FromBody] CreateNewItemsDTO dto)
        {
            string proc = "INSERT_NEW_ITEM";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@item_name", dto.ItemName);
            command.Parameters.AddWithValue("@item_type", dto.ItemType);
            command.Parameters.AddWithValue("@item_Price", dto.ItemPrice);
            command.Parameters.AddWithValue("@item_status", dto.ItemStatus);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Add New Item Done" : "Failed To Add New Item");
        }
        #endregion


        #region Add Meal
        [HttpPost]
        [Route("[action]")]
        public IActionResult AddNewMeal([FromBody] CreateNewMealsDTO dto)
        {
            string proc = "INSERT_NEW_MEAL";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@meal_name", dto.MealName);
            command.Parameters.AddWithValue("@meal_type", dto.MealType);
            command.Parameters.AddWithValue("@meal_price", dto.MealPrice);
            command.Parameters.AddWithValue("@meal_status", dto.MealStatus);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Add New Meal Done" : "Failed To Add New Meal");
        }
        #endregion


        #region Add Order
        [HttpPost]
        [Route("[action]")]
        public IActionResult AddNewOrder([FromBody] CreateNewOrdersDTO dto)
        {
            DateTime myDateTime = DateTime.Now;
            string formattedDateTime = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string proc = "INSERT_NEW_ORDER";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@total_price", dto.TotalPrice);
            command.Parameters.AddWithValue("@order_status", dto.OrderStatus);
            command.Parameters.AddWithValue("@order_date", formattedDateTime);
            command.Parameters.AddWithValue("@employee_id", dto.EmployeeId);
            command.Parameters.AddWithValue("@item_id", dto.ItemId);
            command.Parameters.AddWithValue("@meal_id", dto.MealId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Add New Order Done" : "Failed To Add New Order");
        }
        #endregion
    }
}
