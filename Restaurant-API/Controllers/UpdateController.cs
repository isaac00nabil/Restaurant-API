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
    public class UpdateController : ControllerBase
    {




        #region Update Items
        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateItemsData([FromBody]UpdateNewItemsDTO dto)
        {
            string proc = "UPDATE_ITEM";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@item_id", dto.ItemId);
            command.Parameters.AddWithValue("@item_name", dto.ItemName);
            command.Parameters.AddWithValue("@item_type", dto.ItemType);
            command.Parameters.AddWithValue("@item_Price", dto.ItemPrice);
            command.Parameters.AddWithValue("@item_status", dto.ItemStatus);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Update Item Information Done" : "Failed To Update Item Information");
        }
        #endregion


        #region Update Meals 
        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateMealsData([FromBody] UpdateMealsDTO dto)
        {
            string proc = "UPDATE_MEAL";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@meal_id", dto.MealId);
            command.Parameters.AddWithValue("@meal_name", dto.MealName);
            command.Parameters.AddWithValue("@meal_type", dto.MealType);
            command.Parameters.AddWithValue("@meal_price", dto.MealPrice);
            command.Parameters.AddWithValue("@meal_status", dto.MealStatus);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Update Meal Information Done" : "Failed To Update Meal Information");
        }
        #endregion


        #region Update Orders
        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateOrdersData([FromBody] UpdateOrdersDTO dto)
        {
            string proc = "UPDATE_ORDER";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@order_id", dto.OrderId);
            command.Parameters.AddWithValue("@total_price", dto.TotalPrice);
            command.Parameters.AddWithValue("@order_status", dto.OrderStatus);
            command.Parameters.AddWithValue("@order_date", dto.OrderDate);
            command.Parameters.AddWithValue("@employee_id", dto.EmployeeId);
            command.Parameters.AddWithValue("@item_id", dto.ItemId);
            command.Parameters.AddWithValue("@meal_id", dto.MealId);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return Ok(rows > 0 ? "Update Order Information Done" : "Failed To Update Order Information");
        }
        #endregion




    }
}
