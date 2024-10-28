using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****** Menü Sipariş İşlem Paneli ******");
            Console.WriteLine();
            #region Kategori ekleme işlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-K1D8RIIA;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tblcategory (categoryname) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori eklendi !");

            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;
            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data source=LAPTOP-K1D8RIIA;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values(@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklendi");

            #endregion

            #region Ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data source=LAPTOP-K1D8RIIA;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from tblproduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün silme işlemi

            //Console.Write("Silinecek ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data source=LAPTOP-K1D8RIIA;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProfuctId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi gerçekleşti");

            #endregion

            #region Ürün güncelleme işlemi

            //Console.Write("Ürün ID: ");
            //int productId=int.Parse(Console.ReadLine());
            //Console.Write("Ürün ad: ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün fiyat: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data source=LAPTOP-K1D8RIIA;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("update tblproduct set ProductName=@productName,ProductPrice=@productPrice where ProfuctId=@productId",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme başarılı");

            #endregion

            Console.Read();
        }
    }
}
