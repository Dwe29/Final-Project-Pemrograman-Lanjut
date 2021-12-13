using System.Data;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class UsersModel
    {
        private ModelTemplate _template;
        
        public string nama { get; set; }
        public string password { get; set; }

        public UsersModel()
        {
            _template = new ModelTemplate();
        }

        public bool CheckLogin()
        {
            bool result;
            DataSet ds;
            ds = _template.Select("users", "name = '" + nama + "' AND password = '" + password + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool AddUsers()
        {
            var data = "'" + nama + "','" + password + "'";
            return _template.Insert("users", data);
        }
    }
}