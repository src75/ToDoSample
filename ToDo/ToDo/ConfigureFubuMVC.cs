using System;
using FubuMVC.Core;
using FubuMVC.Spark;
using ToDo.ToDo;

namespace ToDo
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            Actions.FindBy(x => 
            { 
                x.Applies.ToThisAssembly(); 
                x.IncludeClassesSuffixedWithController();
            });

            Routes.HomeIs<ToDoController>(c => c.Index()).IgnoreControllerNamespaceEntirely();
            Import<SparkEngine>();
        }
    }
}