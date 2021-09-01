using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WorkflowEngine
{

    class Program
    {

        static void Main(string[] args)
        {
            var workflowengine = new Workflowengine();
            var work = new workflow();
            work.RegisterActivity(new UploadVideo());
            work.RegisterActivity(new NotifyService());
            work.RegisterActivity(new SendEmailuser());
            work.RegisterActivity(new Changevideostatus());
            workflowengine.Run(work);




        }
    }
}
