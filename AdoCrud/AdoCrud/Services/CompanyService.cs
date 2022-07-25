using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AdoCrud.EDM;

namespace AdoCrud.Services
{
    public class CompanyService : ICompanyService
    {
        SqlConnection cn;
        public CompanyService()
        {
            cn = new SqlConnection("Data Source=DESKTOP-52IAUQR;Initial Catalog=Company;Integrated Security=True");
        }

        public List<tblemployee> GetEmployees()
        {
            List<tblemployee> li = new List<tblemployee>();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblemployee", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                //DateTime? dtm = 
                li.Add(new tblemployee
                {
                    emp_id = Convert.ToInt32(item["emp_id"].ToString()),
                    salary = Convert.ToInt32(item["salary"].ToString()),
                    f_name = item["f_name"].ToString(),
                    mobile = item["mobile"].ToString(),
                    email = item["email"].ToString(),
                    password = item["password"].ToString(),
                    gender = item["gender"].ToString(),
                    address = item["address"].ToString(),
                    dob = item.Field<DateTime?>("dob")
            });
            }

            return li;
        }

        public tblemployee GetEmployeeById(int id)
        {
            tblemployee li = new tblemployee();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblemployee where emp_id=" + id, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                li.emp_id = Convert.ToInt32(dt.Rows[0]["emp_id"].ToString());
                li.salary = Convert.ToInt32(dt.Rows[0]["salary"].ToString());
                li.f_name = dt.Rows[0]["f_name"].ToString();
                li.mobile = dt.Rows[0]["mobile"].ToString();
                li.email = dt.Rows[0]["email"].ToString();
                li.password = dt.Rows[0]["password"].ToString();
                li.gender = dt.Rows[0]["gender"].ToString();
                li.address = dt.Rows[0]["address"].ToString();
            }

            return li;
        }

        public void AddEmployee(tblemployee obj)
        {
            SqlCommand cmd = new SqlCommand("insert into tblemployee(f_name,salary,mobile,email,password,gender) values(@fn,@sl,@mb,@em,@ps,@gn)",cn);
            cmd.Parameters.AddWithValue("@fn",obj.f_name);
            cmd.Parameters.AddWithValue("@sl",obj.salary);
            cmd.Parameters.AddWithValue("@mb",obj.mobile);
            cmd.Parameters.AddWithValue("@em",obj.email);
            cmd.Parameters.AddWithValue("@ps",obj.password);
            cmd.Parameters.AddWithValue("@gn",obj.gender);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateEmployee(tblemployee obj)
        {
            SqlCommand cmd = new SqlCommand("update tblemployee set f_name=@fn,salary=@sl,mobile=@mb,email=@em,password=@ps,gender=@gn where emp_id=@id", cn);
            cmd.Parameters.AddWithValue("@fn", obj.f_name);
            cmd.Parameters.AddWithValue("@id", obj.emp_id);
            cmd.Parameters.AddWithValue("@sl", obj.salary);
            cmd.Parameters.AddWithValue("@mb", obj.mobile);
            cmd.Parameters.AddWithValue("@em", obj.email);
            cmd.Parameters.AddWithValue("@ps", obj.password);
            cmd.Parameters.AddWithValue("@gn", obj.gender);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void DeleteEmployee(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from tblemployee where emp_id=@id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}