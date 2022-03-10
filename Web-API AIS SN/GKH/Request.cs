using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web_API_AIS_SN.GKH
{

    public class Param
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class ListAccount
    {
        public string Number { get; set; }
        public bool ByEmail { get; set; }
    }

    public class RequestToMpaCreate
    {
        public string TypeRequest { get; set; }
        public string MetodRequest { get; set; }
        public List<Param> @params { get; set; }
        public List<Param> @jsonIn { get; set; }
    }


    public class Request
    {
        public string TypeRequest { get; set; }
        public string MetodRequest { get; set; }     
        public List<Param> @params { get; set; }
        //SqlParameter[] GetSqlPatameters()
        //{ 
        //    SqlParameter[] param=new SqlParameter[@params.Count];
        //    for(int i=0;i< @params.Count;i++)
        //    {
        //        param[i] = new SqlParameter(@params[i].Name, SqlDbType.VarChar, 200) {Value= @params[i].value};
        //    }
        //    return param;
        //}

        //public string  Run()
        //{
        //    var sql = "";
        //    //using (var smsr = new SmsrDataContext())
        //    //{
        //    //    sql = smsr.Cursors.Where(z => z.typeMetod == metodRequest).FirstOrDefault().sql;
        //    //    var calls = smsr.IpPhoneRequests.Where(z => z.ip == ip && (DateTime.Now - z.requestTime).Minutes > 20).ToList();
        //    //    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Request));
        //    //    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<IpPhoneRequests>));
        //    //    MemoryStream msObj = new MemoryStream();
        //    //    js.WriteObject(msObj, calls);
        //    //    msObj.Position = 0;
        //    //    StreamReader sr = new StreamReader(msObj);

        //    //    // "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}"  
        //    //    string json = sr.ReadToEnd();

        //    //    sr.Close();
        //    //    msObj.Close();
        //    //    //var json = jsonSerializer.SerializeObject(bsObj)
        //    //    //vaqwerq qwe = smsr.AddNewAbonent()
        //    //    //var qwe = smsr("Cursors")

        //    //    //var qwe == DALSql.ExecuteDataTable(query, sp)

        //    //    //using (SqlConnection sqlConnectionSmsr = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sn_sms_router_moskovConnectionString"].ConnectionString))
        //    //    //{
        //    //    //    DALSql.ExecuteDataTable(query, sp)

        //    //    //    //var sSQL = @"

        //    //    //    using (SqlCommand objCmd = new SqlCommand(sql, sqlConnectionSmsr,))
        //    //    //    {
        //    //    //        sqlConnectionSmsr.Open();
        //    //    //        var res = objCmd.ExecuteReader();
        //    //    //        sqlConnectionSmsr.Close();

        //    //    //    }

        //    //    //    //if (String.IsNullOrEmpty(id))
        //    //    //    //    sSQLsmsr = "SELECT id,baseName,baseIp,area FROM smsr.WebServices where area is not null";
        //    //    //    //else
        //    //    //    //    sSQLsmsr = "SELECT baseName,baseIp,area FROM smsr.WebServices where area is not null and id = " + id + "";


        //    //    //    //using (SqlCommand objCmdsmsr = new SqlCommand(sSQLsmsr, sqlConnectionSmsr))
        //    //    //    //{
        //    //    //    //    sqlConnectionSmsr.Open();

        //    //    //    //    SqlDataReader myReadersmsr = objCmdsmsr.ExecuteReader();

        //    //    //    //    while (myReadersmsr.Read())
        //    //    //    //    {

        //    //    //    //        webservices.Add(new Smsr_webservice { id = myReadersmsr["id"].ToString(), baseName = myReadersmsr["baseName"].ToString(), baseIp = myReadersmsr["baseIp"].ToString(), area = myReadersmsr["area"].ToString() });
        //    //    //    //    }
        //    //    //    //}
        //    //    //}


        //    //}
        //    //1. Определяем метод в SN_SMS_ROUTER в таблице cursors
        //    //2. Получает запрос 
        //    //3. Опеределякем базуу
        //    //4. Выполняем запрос
        //    //5. Получить стоку из DataTable
        //    return "";
        //}
    }


}