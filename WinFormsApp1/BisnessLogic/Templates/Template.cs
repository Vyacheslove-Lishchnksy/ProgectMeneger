using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMeneger.BisnessLogic.Templates
{
    public class Template : ITemplate
    {
        public string Name { get; }
        private IList<string> Paths { get; }

        public Template(string templateName, IList<string> template)
        {
            Name = templateName;
            Paths = new List<string>(template);
        }

        public void AddPath(string path)
        {
            Paths.Add(path);
        }


    }
}
