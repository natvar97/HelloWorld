using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HttpCookie
    {
        private Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }


        public string this[string key] {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

    }
}
