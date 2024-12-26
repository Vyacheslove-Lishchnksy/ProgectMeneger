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
        private IList<string> Paths;

        public Template(string templateName, IList<string> template)
        {
            Name = templateName;
            Paths = new List<string>(template);
        }

        public void AddPath(string path)
        {
            Paths = new List<string>(Paths) { path };
        }

        public IList<string> GetPaths()
        {
            return new List<string>(Paths);
        }

        public void NewPaths(IList<string> paths)
        {
            Paths = new List<string>(paths);
        }
    }
}
