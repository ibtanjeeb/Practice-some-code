using System.Collections.Generic;
namespace WorkflowEngine
{
    class workflow : IWorkFlow
    {
        private readonly IList<IActiviy> _Activities;
        public workflow()
        {
            _Activities = new List<IActiviy>();
        }
        public void  DeRegisterActivity(IActiviy activiy)
        {
            _Activities.Remove(activiy);
        }
        public IEnumerable<IActiviy>GetActiviys()
        {
            return _Activities;
        }

        public void RegisterActivity(IActiviy activiy)
        {
            _Activities.Add(activiy);
        }
    }
}
