using System;
using System.Data.SqlClient;

namespace SQLdn
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //---连接字符串
            string connstring = "Data Source=.;Initial Catalog=AirTicket;Integrated Security=True";
             //创建连接对象
            SqlConnection conn = new SqlConnection(connstring);
            //设置命令对象
            SqlCommand cmd = conn.CreateCommand();
            //打开数据连接
            conn.Open();
            //设置Ssq语句
            //delet Aircompany where hotLine='A'
            //update Aircompany set hotLine='95539' where companyName ='职院航空'
            //cmd.CommandText = "inset into AirCompany values('衡阳航空','衡阳市南岳','95538'";
           // cmd.CommandText = "delete AirCompany where hotLine='A'";
            cmd.CommandText = "update AirCompany set hotLine='95539' where companyName='职院航空'";
            //执行命令
            cmd.ExecuteNonQuery();
            //关闭数据连接
            conn.Close();
        }
    }
}
