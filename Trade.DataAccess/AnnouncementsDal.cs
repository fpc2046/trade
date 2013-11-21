using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    /// <summary>
    /// 公告表
    /// </summary>
    public class AnnouncementsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Announcement model)
        {
            var strSql = new StringBuilder();
            strSql.Append("insert into Announcement(");
            strSql.Append("SeriesNum,Institution,Theme,ContentText,CreateTime,Overtime,UserName)");
            strSql.Append(" values (");
            strSql.Append("@SeriesNum,@Institution,@Theme,@ContentText,@CreateTime,@Overtime,@UserName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SeriesNum", SqlDbType.Int,4),
					new SqlParameter("@Institution", SqlDbType.VarChar,50),
					new SqlParameter("@Theme", SqlDbType.VarChar,300),
					new SqlParameter("@ContentText", SqlDbType.Text),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Overtime", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50)};
            parameters[0].Value = model.SeriesNum;
            parameters[1].Value = model.Institution;
            parameters[2].Value = model.Theme;
            parameters[3].Value = model.ContentText;
            parameters[4].Value = model.CreateTime;
            parameters[5].Value = model.Overtime;
            parameters[6].Value = model.UserName;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Announcement model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update Announcement set ");
            strSql.Append("SeriesNum=@SeriesNum,");
            strSql.Append("Institution=@Institution,");
            strSql.Append("Theme=@Theme,");
            strSql.Append("ContentText=@ContentText,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("Overtime=@Overtime,");
            strSql.Append("UserName=@UserName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SeriesNum", SqlDbType.Int,4),
					new SqlParameter("@Institution", SqlDbType.VarChar,50),
					new SqlParameter("@Theme", SqlDbType.VarChar,300),
					new SqlParameter("@ContentText", SqlDbType.Text),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Overtime", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.SeriesNum;
            parameters[1].Value = model.Institution;
            parameters[2].Value = model.Theme;
            parameters[3].Value = model.ContentText;
            parameters[4].Value = model.CreateTime;
            parameters[5].Value = model.Overtime;
            parameters[6].Value = model.UserName;
            parameters[7].Value = model.ID;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            var strSql = new StringBuilder();
            strSql.Append("delete from Announcement ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = id;
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string dlist)
        {
            var strSql = new StringBuilder();
            strSql.Append("delete from Announcement ");
            strSql.Append(" where ID in (" + dlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<Announcement> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                " ID,SeriesNum,Institution,Theme,ContentText,CreateTime,Overtime,UserName from Announcement ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<Announcement>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new Announcement();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["SeriesNum"] != null && dr["SeriesNum"].ToString() != "")
                    {
                        model.SeriesNum = int.Parse(dr["SeriesNum"].ToString());
                    }
                    if (dr["Institution"] != null)
                    {
                        model.Institution = dr["Institution"].ToString();
                    }
                    if (dr["Theme"] != null)
                    {
                        model.Theme = dr["Theme"].ToString();
                    }
                    if (dr["ContentText"] != null)
                    {
                        model.ContentText = dr["ContentText"].ToString();
                    }
                    if (dr["CreateTime"] != null && dr["CreateTime"].ToString() != "")
                    {
                        model.CreateTime = DateTime.Parse(dr["CreateTime"].ToString());
                    }
                    if (dr["Overtime"] != null && dr["Overtime"].ToString() != "")
                    {
                        model.Overtime = DateTime.Parse(dr["Overtime"].ToString());
                    }
                    if (dr["UserName"] != null)
                    {
                        model.UserName = dr["UserName"].ToString();
                    }
                    list.Add(model);
                }
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Clean()
        {
            var strSql = new StringBuilder();
            strSql.Append("delete from Announcement; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
