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
    public class DeleteController : ControllerBase
    {
        #region Delete Employees

        [HttpDelete]
        [Route("[action]/{employeeId}")]

        public IActionResult DeletFromEmployees(string employeeId)
        {
            string proc = "DELETE_EMPLOYEE";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@employee_id", employeeId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Delete Employee Done" : "Delete Employee Failed");
        }
        #endregion


        #region Delete Items
        [HttpDelete]
        [Route("[action]/{itemId}")]

        public IActionResult DeletFromItems(string itemId)
        {
            string proc = "DELETE_ITEM";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@item_id", itemId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Delet Item Done" : "Failed To Delete Item");
        }
        #endregion


        #region Delete Meals
        [HttpDelete]
        [Route("[action]/{mealId}")]

        public IActionResult DeletFromMeals(string mealId)
        {
            string proc = "DELETE_MEAL";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@meal_id", mealId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Delet Meal Done" : "Failed To Delete Meal");
        }
        #endregion


        #region Delete Orders
        [HttpDelete]
        [Route("[action]/{orderId}")]

        public IActionResult DeletFromOrders(string orderId)
        {
            string proc = "DELETE_ORDER";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@order_id", orderId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Delet Order Done" : "Failed To Delete Order");
        }
        #endregion

    }
}
