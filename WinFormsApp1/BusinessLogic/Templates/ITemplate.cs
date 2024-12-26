using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMeneger.BisnessLogic.Templates
{
    public interface ITemplate
    {
        public string Name { get; }

        public void AddPath(string path);

        public IList<string> GetPaths();

        public void NewPaths(IList<string> paths);
    }
}
