using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBHelper
    {
        #region 成员

        //数据连接字符串
        public static string connStr = "Data Source = localhost; database = CSharpTest;User ID = Coder;password = 123456";

        #endregion

        #region 属性

        #endregion

        #region 学生类方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool AddStudent(Student model)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Students(");
            strSql.Append("Stu_Number,Stu_Name,Extra)");
            strSql.Append(" values (");
            strSql.Append("@Stu_Number,@Stu_Name,@Extra)");
            SqlParameter[] parameters = {
					new SqlParameter("@Stu_Number", SqlDbType.NVarChar,20),
					new SqlParameter("@Stu_Name", SqlDbType.NVarChar,20),
					new SqlParameter("@Extra", SqlDbType.Text)};
            parameters[0].Value = model.Number;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Extra;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateStudent(Student model)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Students set ");
            strSql.Append("Stu_Name=@Stu_Name,");
            strSql.Append("Extra=@Extra");
            strSql.Append(" where Stu_Number=@Stu_Number ");
            SqlParameter[] parameters = {
					new SqlParameter("@Stu_Name", SqlDbType.NVarChar,20),
					new SqlParameter("@Extra", SqlDbType.Text),
					new SqlParameter("@Stu_Number", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Extra;
            parameters[2].Value = model.Number;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteStudent(string Stu_Number)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Students ");
            strSql.Append(" where Stu_Number=@Stu_Number ");
            SqlParameter[] parameters = {
					new SqlParameter("@Stu_Number", SqlDbType.NVarChar,20)			};
            parameters[0].Value = Stu_Number;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<Student> GetStudentList()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlDataReader sqlDataReader = null;
            List<Student> studentList = new List<Student>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Stu_Number,Stu_Name,Extra ");
            strSql.Append(" FROM Students ");
            //if (strWhere.Trim() != "")
            //{
            //    strSql.Append(" where " + strWhere);
            //}
            SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                //循环读出所有学生
                Student student = new Student((string)sqlDataReader["Stu_Number"]);
                student.Name = (string)sqlDataReader["Stu_Name"];
                student.Extra = (string)sqlDataReader["Extra"];
                studentList.Add(student);  //加入学生集合
            }
            conn.Close();
            return studentList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static DataSet GetStudentDataSet(string strWhere)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = new DataSet();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Stu_Number,Stu_Name,Extra ");
            strSql.Append(" FROM Students ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            sqlDataAdapter = new SqlDataAdapter(strSql.ToString(), conn);
            sqlDataAdapter.Fill(ds, "HallSeat");
            conn.Close();
            return ds;
        }

        #endregion

        #region 课程类方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool AddCourse(Course model)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Courses(");
            strSql.Append("Course_Number,Course_Name,Course_Message)");
            strSql.Append(" values (");
            strSql.Append("@Course_Number,@Course_Name,@Course_Message)");
            SqlParameter[] parameters = {
					new SqlParameter("@Course_Number", SqlDbType.NVarChar,20),
					new SqlParameter("@Course_Name", SqlDbType.NVarChar,20),
					new SqlParameter("@Course_Message", SqlDbType.Text)};
            parameters[0].Value = model.Number;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Message;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateCourse(Course model)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Course_Name=@Course_Name,");
            strSql.Append("Course_Message=@Course_Message");
            strSql.Append(" where Course_Number=@Course_Number ");
            SqlParameter[] parameters = {
					new SqlParameter("@Course_Name", SqlDbType.NVarChar,20),
					new SqlParameter("@Course_Message", SqlDbType.Text),
					new SqlParameter("@Course_Number", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Message;
            parameters[2].Value = model.Number;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteCourse(string Course_Number)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Courses ");
            strSql.Append(" where Course_Number=@Course_Number ");
            SqlParameter[] parameters = {
					new SqlParameter("@Course_Number", SqlDbType.NVarChar,20)			};
            parameters[0].Value = Course_Number;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<Course> GetCourseList()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlDataReader sqlDataReader = null;
            List<Course> courseList = new List<Course>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Course_Number,Course_Name,Course_Message ");
            strSql.Append(" FROM Courses ");
            //if (strWhere.Trim() != "")
            //{
            //    strSql.Append(" where " + strWhere);
            //}
            SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                //循环读出所有学生
                Course course = new Course((string)sqlDataReader["Course_Number"]);
                course.Name = (string)sqlDataReader["Course_Name"];
                course.Message = (string)sqlDataReader["Course_Message"];
                courseList.Add(course);  //加入学生集合
            }
            conn.Close();
            return courseList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static DataSet GetCourseDataSet(string strWhere)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = new DataSet();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Course_Number,Course_Name,Course_Message ");
            strSql.Append(" FROM Courses ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            sqlDataAdapter = new SqlDataAdapter(strSql.ToString(), conn);
            sqlDataAdapter.Fill(ds, "HallSeat");
            conn.Close();
            return ds;
        }

        #endregion

        #region 记录类方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool AddRecord(string stuNumber, string courseNumber, DateTime datetime)
        {
            int number;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RegTime(");
            strSql.Append("Stu_Number,Course_Number,Reg_Time)");
            strSql.Append(" values (");
            strSql.Append("@Stu_Number,@Course_Number,@Reg_Time)");
            SqlParameter[] parameters = {
					new SqlParameter("@Stu_Number", SqlDbType.NVarChar,20),
					new SqlParameter("@Course_Number", SqlDbType.NVarChar,20),
					new SqlParameter("@Reg_Time", SqlDbType.DateTime)};
            parameters[0].Value = stuNumber;
            parameters[1].Value = courseNumber;
            parameters[2].Value = datetime;
            cmd = new SqlCommand(strSql.ToString(), conn);
            foreach (SqlParameter para in parameters)
            {
                cmd.Parameters.Add(para);
            }
            number = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (number == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        public static DataSet GetRecordDataSet(string strWhere)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = new DataSet();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Stu_Number,Course_Number,Reg_Time ");
            strSql.Append(" FROM RegTime ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            sqlDataAdapter = new SqlDataAdapter(strSql.ToString(), conn);
            sqlDataAdapter.Fill(ds, "HallSeat");
            conn.Close();
            return ds;
        }

        #endregion

        #region


        #endregion
    }
}
