using Anställda_med_arv_och_polymorfism;

List<Employee> employees = new List<Employee>();
Manager manager = new Manager();
Developer developer = new Developer();
SalesPerson salesPerson = new SalesPerson();

manager.Name = "Jonas";
manager.HourPay = 500;
manager.WorkHours = 80;
employees.Add(manager);

developer.Name = "Sven";
developer.HourPay = 250;
developer.WorkHours = 120;
employees.Add(developer);

salesPerson.Name = "Sara";
salesPerson.HourPay = 200;
salesPerson.WorkHours = 90;
employees.Add(salesPerson);

for(int i = 0; i < employees.Count; i++)
{
    string job = "";
    if (employees[i] is Manager) job = "Chef | ";
    else if (employees[i] is Developer) job = "Utvecklare | ";
    else if (employees[i] is SalesPerson) job = "Försäljare | ";
    Console.WriteLine(job+employees[i].Name 
    + " jobbade " + employees[i].WorkHours 
    + " timmar och har " + employees[i].HourPay 
    + " kr i timmen, vilket blir: " + employees[i].CalculateSalary() + " kr");
}