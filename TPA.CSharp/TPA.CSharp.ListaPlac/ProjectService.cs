using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TPA.CSharp.ListaPlac
{
    public class ProjectService
    {
        public Collection<string> Get()
        {
            Collection<string> projects = new Collection<string>();
            projects.Add("Project A");
            projects.Add("Project B");
            projects.Add("Project C");

            return projects;
        }
    }
}
