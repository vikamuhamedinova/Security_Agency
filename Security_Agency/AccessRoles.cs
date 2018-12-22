using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Agency
{
    public enum AccessRoles
    {
        Director,   // Начальник отдела вневедомственной охраны               
        Manager,    // Сотрудник отдела по работе с клиентами            
        Accountant, // Бухгалтер                 
        Inspector,  // Руководитель выездной бригады
        HRManager,  // Сотрудник отдела кадров
        Adjuster,   // Специалист по монтажу оборудования
        Dispatcher  // Дежурный               
    }
}
