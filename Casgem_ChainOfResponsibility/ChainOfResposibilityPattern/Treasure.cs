using Casgem_ChainOfResponsibility.DAL;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResposibilityPattern
{
    public class Treasure : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount<=50000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Mert Can";
                customerProcess.Description = "Müşterinin talep ettiği tutar Veznedar tarafından ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName= req.CustomerName;
                customerProcess.EmployeeName = "Mert Can";
                customerProcess.Description = "Müşteri tarafından talep edilen tutar günlük limitimi aştığından şube müdür yardımcımıza yönlendirmek zorundayım";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
