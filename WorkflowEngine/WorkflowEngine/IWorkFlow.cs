using System;
using System.Collections.Generic;
namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void RegisterActivity(IActiviy activiy);
        IEnumerable<IActiviy> GetActiviys();
        void DeRegisterActivity(IActiviy activiy);
        



    }
}
