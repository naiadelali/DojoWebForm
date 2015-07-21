using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoWebForm.DAO;
using System.Data;
using DojoWebForms.Model;

namespace DojoWebForm.BLL
{
    public class UnitMeasureBLL
    {
        private UnitMeasureDAO db = new UnitMeasureDAO();

        public List<UnitMeasure> SelectAll()
        {
            return db.SelectAll();
        }

        public void Inserir(UnitMeasure unitMeasure)
        {
            db.Inserir(unitMeasure);
        }
    }
}
