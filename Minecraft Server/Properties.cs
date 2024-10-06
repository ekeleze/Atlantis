using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server
{
    internal class Properties
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>();

        public bool AddPropertyFromLine(string line)
        {
            if (line.StartsWith("#")) return true;
            else if (line.EndsWith("=") || line.StartsWith("=")) return false;
            else
            {
                string[] data = line.Split("=");

                if (long.TryParse(data[1], out _)) AddProperty(data[0], long.Parse(data[1])); 
                else if (bool.TryParse(data[1], out _)) AddProperty(data[0], bool.Parse(data[1]));
                else AddProperty(data[0], data[1]);

                return true;
            }
        }

        public bool AddProperty(string key, object value)
        {
            if (!properties.TryGetValue(key, out _))
            {
                properties.Add(key, value);
                return true;
            }

            return false;
        }

        public object GetProperty(string key)
        {
            if (properties.TryGetValue(key, out _))
            {
                object ass = 0;
                properties.TryGetValue(key, out ass);
                return ass;
            }

            return null;
        }

        public bool TryGetProperty(string key, out object val)
        {
            if (properties.TryGetValue(key, out _))
            {
                properties.TryGetValue(key, out val!);
                return true;
            }

            val = null!;
            return false;
        }

        public object GetPropertyFromLine(string line)
        {
            if (line.StartsWith("#")) return null!;
            else if (line.EndsWith("=") || line.StartsWith("=")) return null!;
            else
            {
                string[] data = line.Split("=");

                if (int.TryParse(data[1], out _)) return int.Parse(data[1]); 
                else if (bool.TryParse(data[1], out _)) return bool.Parse(data[1]);
                else return data[1];
            }
        }
    }
}
