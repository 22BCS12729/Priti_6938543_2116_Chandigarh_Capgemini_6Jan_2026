using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlmanac
{
    internal class Almanac
    {
            public Dictionary<string, List<string>> projects
                = new Dictionary<string, List<string>>();

            public string assignProject(string name, string project)
            {
                if (!projects.ContainsKey(name))
                {
                    projects[name] = new List<string>();
                }

                projects[name].Add(project);
                return "Project assigned successfully.";
            }

            public List<string> currentProjects(string name)
            {
                if (projects.ContainsKey(name))
                {
                    return projects[name];
                }

                return new List<string>();
            }

            public string finishProject(string name, string project)
            {
                if (projects.ContainsKey(name) && projects[name].Contains(project))
                {
                    projects[name].Remove(project);
                    return "Project finished successfully.";
                }

                return "Project or agent not found.";
            }
        }

    }

