using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoWebForms.Model;

namespace DojoWebForm.DAO
{
    public class UnitMeasureDAO
    {
        public List<UnitMeasure> SelectAll()
        {
            List<UnitMeasure> lst = new List<UnitMeasure>();

            using (DataTable dt = DbCommands.ExecuteProcedure("SelectAllUnitMeasure"))
            {
                foreach(DataRow dr in dt.Rows)
                {
                    UnitMeasure u = new UnitMeasure()
                    {
                        Id = (int)dr["Id"],
                        Description = dr["Description"].ToString(),
                        Abbreviation = dr["Abbreviation"].ToString()
                    };

                    lst.Add(u);
                }
            }

            return lst;
        }

        public void Inserir(UnitMeasure unitMeasure)
        {
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter("@Abbreviation",unitMeasure.Abbreviation),
                new SqlParameter("@Description",unitMeasure.Description)
            };

            DbCommands.ExecuteProcedure("InsertUnitMeasure", parametros);
        }
    }
}
