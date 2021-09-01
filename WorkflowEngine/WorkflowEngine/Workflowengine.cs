using System;
using System.Collections.Generic;
namespace WorkflowEngine
{
    public class Workflowengine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var Activity in workFlow.GetActiviys())
            {
                Activity.Execute();
            }

        }
    }
}
