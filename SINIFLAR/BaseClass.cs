using System.Collections.Generic;
using System.Data.SqlClient;

namespace SinavSistemi
{
   public class BaseClass<T>
    {
        public SqlCommand komut;
        public SqlDataReader reader;
        public int donusdeger;
        public List<T> liste;
        public T data;
    }
}
