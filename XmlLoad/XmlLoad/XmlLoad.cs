using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlLoader 
{
    public class XmlLoad
    {
        public static DataSet Load()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML Files|*.xml";
            openFile.Title = "Select XML import file";

            DataSet xml_data = new DataSet();


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("plik:" + openFile.FileName);

              

                xml_data.ReadXml(openFile.FileName, XmlReadMode.InferSchema);

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
            return xml_data;

        }
    }
}
