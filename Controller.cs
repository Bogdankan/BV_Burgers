using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BV_Burgers.Controllers
{
    [Serializable]
    abstract class Controller
    {
        protected void Save(string filename, object item)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }

        protected T Load<T>(string filename)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    if (fs.Length > 0 && formatter.Deserialize(fs) is T items)
                    {
                        return items;
                    } 
                }
                catch (Exception)
                {
                    return default;
                }
                return default;
            }
        }


    }
}
