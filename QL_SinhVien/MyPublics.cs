using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SinhVien
{
    public class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMSSV, strLop, strQuyenSD, strHK, strNK;

        public static void ConnectDatabase()
        { // ket noi voi CSDL
            string strConn = "Server= localhost; Database= QL_SinhVien; Integrated Security= false; UID= TN207User; PWD= TN207User";
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strConn;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception)
            { 
            }
        }

        public static string MaHoaPassword(string strPassword)
        { // ma hoa password
            string strTemp1 = "", strTemp2 = "";
            int i, n;
            n = strPassword.Length;
            for (i = 0; i < n; i = i + 2)
            {
                strTemp1 = strTemp1 + strPassword[i];
                if (n > i + 1)
                    strTemp2 = strTemp2 + strPassword[i + 1];
            }
            return (strTemp1 + strTemp2);
        }

        public static void OpenData(string strSelect, DataSet dsDatabase, string strTableName, SqlDataAdapter daDataAdapter)
        { // truy xuat du lieu
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                SqlCommandBuilder cmdCommandBuilder = new SqlCommandBuilder(daDataAdapter);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conMyConnection.Close();
            }
            catch (Exception)
            { 
            }
        }

        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        { // kiem tra khoa chinh
            bool blnRessult = false;
            try
            {
                string sqlQuery = "SELECT 1 FROM " + strTable + " WHERE " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(sqlQuery, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
                if (drReader.HasRows)
                    blnRessult = true;
                drReader.Close();
                conMyConnection.Close();
            }
            catch (Exception) 
            { 
            }
            return blnRessult;
        }

        public static void OpenData(string strSelect, DataSet dsDatabase, string strTableName)
        {
            SqlDataAdapter daDataAdapter = new SqlDataAdapter();
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
