using Casgem_ChainOfResponsibility.DAL;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResposibilityPattern
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 300000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Hakan Bahşiş";
                customerProcess.Description = "Müşterinin talep ettiği tutar Bölge Müdürü tarafından ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Hakan Bahşiş";
                customerProcess.Description = "Müşteri tarafından talep edilen tutar günlük limitimi aştığından işlem gerçekleştirilemez";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
