using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CRUD_WebAPI;
using Dapper;

namespace CRUD_WebAPI
{
    public class MobileRepository
    {
        Mobile obj = new Mobile();
        string connectionstring = "Data Source=desktop-blbgehj\\sqlexpress;Initial Catalog=Mobile;User Id=sa;Password=Anaiyaan@123;";
        SqlConnection s;
        public MobileRepository()
        {
           // var connectionstring = "Data Source=desktop-blbgehj\\sqlexpress;Initial Catalog=Mobile;User Id=sa;Password=Anaiyaan@123;";
          s = new SqlConnection(connectionstring);
        }

        public void Inserting(Mobile obj) 
        {
            var insert = $"Insert into Mobile Values('{obj.Name}','{obj.Model}',{obj.NoOfSim},'{obj.ManufacturedBy}','{obj.SupplierName}')";
           // SqlConnection s = new SqlConnection(connectionstring);
            s.Open();
            s.Execute(insert);
            s.Close();  

        }

        public IEnumerable<Mobile>Showall()
        {
            var showing = $"select*from Mobile";
           // SqlConnection s = new SqlConnection(connectionstring);
            s.Open();
            var result=s.Query<Mobile>(showing);
            s.Close();

            return result;

        }

        public void update(string Name,string Model)
        {
            var updating = $"update Mobile set Model ='{Model}' where Name = '{Name}'";
            s.Open();
            s.Execute(updating);
            s.Close();


        }

        public void Delete(int MobileId)
        {
            var delete = $"Delete from Mobile where MobileId = {MobileId}";
            s.Open();
            s.Execute(delete);
            s.Close();
        }
        public IEnumerable<Mobile>GetById(int MobileId)
        {
            var Id = $"select*from Mobile where MobileId={MobileId}";
            s.Open();
            var results = s.Query<Mobile>(Id);
            s.Close();

            return results;
        }
    }
}
