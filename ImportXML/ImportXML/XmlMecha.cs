using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;

namespace ImportXML
{
    class XmlMecha
    {
        public XmlMecha()
        {
        }

        public void loadXML(string filepath)
        {
            //XmlDocument xml = new XmlDocument();
            //xml.Load(filepath);


                DataSet xml_data = new DataSet();

                xml_data.ReadXml(filepath, XmlReadMode.InferSchema);

            foreach (DataTable table in xml_data.Tables)
            {
                Console.WriteLine(table);
                for (int i = 0; i < table.Columns.Count; ++i)
                    Console.Write("\t" + table.Columns[i].ColumnName.Substring(0, Math.Min(6, table.Columns[i].ColumnName.Length)));
                Console.WriteLine();
                foreach (var row in table.AsEnumerable())
                {
                    for (int i = 0; i < table.Columns.Count; ++i)
                    {
                        Console.Write("\t" + row[i]);
                    }
                    Console.WriteLine();
                }
            }

        }
        
    }
}
