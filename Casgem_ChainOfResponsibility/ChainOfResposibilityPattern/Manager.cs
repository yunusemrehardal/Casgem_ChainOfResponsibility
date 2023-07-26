using Casgem_ChainOfResponsibility.DAL;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResposibilityPattern
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 200000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Burak Ertan";
                customerProcess.Description = "Müşterinin talep ettiği tutar Şube Müdürü tarafından ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Burak Ertan";
                customerProcess.Description = "Müşteri tarafından talep edilen tutar günlük limitimi aştığından bölge müdürüne yönlendirmek zorundayım";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
