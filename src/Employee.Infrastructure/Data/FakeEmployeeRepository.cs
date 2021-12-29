using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Employee.SharedKernel.Interfaces;

namespace Employee.Infrastructure.Data
{
    public class FakeEmployeeRepository : IRepository<Core.Entities.Employee>
    {
        public async Task<IEnumerable<Core.Entities.Employee>> GetAll(Func<Core.Entities.Employee, bool> where = null)
        {
            if (where != null)
            {
                var result = await FakeData();
                return result.Where(where);
            }

            return await FakeData();
        }

        private static Task<IEnumerable<Core.Entities.Employee>> FakeData()
        {
            #region DataFactory
            //using FileStream stream = File.OpenRead("MOCK_DATA.json");
            //var fakeData = await JsonSerializer.DeserializeAsync<IEnumerable<Entity.Models.Employee>>(stream);

            //var groupedData = fakeData
            //    .GroupBy(g => g.DepartmentName,
            //    (key, g) => new
            //    {
            //        Department = key,
            //        Employees = g.OrderByDescending(p => p.Salary).Take(5).ToList()
            //    }).ToList();

            //var result = new List<Entity.Models.Employee>();
            //string textobj = "";
            //foreach (var item in groupedData)
            //{
            //    foreach (var employee in item.Employees)
            //    {
            //        textobj += $"new Entity.Models.Employee {{ Id = {employee.Id}, GivenName = \"{employee.GivenName}\", Surname = \"{employee.Surname}\", DepartmentName = \"{employee.DepartmentName}\", Salary = {employee.Salary} }},\n";
            //    }
            //    result.AddRange(item.Employees);
            //}
            #endregion

            var result = new List<Core.Entities.Employee>()
            {
                new Core.Entities.Employee { Id = 426, GivenName = "Bobby", Surname = "McCrossan", DepartmentName = "Legal", Salary = 3490 },
                new Core.Entities.Employee { Id = 116, GivenName = "Jobye", Surname = "Marlin", DepartmentName = "Legal", Salary = 3489 },
                new Core.Entities.Employee { Id = 348, GivenName = "Benedick", Surname = "Banham", DepartmentName = "Legal", Salary = 3489 },
                new Core.Entities.Employee { Id = 463, GivenName = "Glyn", Surname = "Rodders", DepartmentName = "Legal", Salary = 3462 },
                new Core.Entities.Employee { Id = 504, GivenName = "Lyn", Surname = "McKim", DepartmentName = "Legal", Salary = 3444 },
                new Core.Entities.Employee { Id = 123, GivenName = "Ronny", Surname = "Shearstone", DepartmentName = "Research and Development", Salary = 3482 },
                new Core.Entities.Employee { Id = 159, GivenName = "Hersch", Surname = "Kelk", DepartmentName = "Research and Development", Salary = 3451 },
                new Core.Entities.Employee { Id = 357, GivenName = "Cathe", Surname = "Gedney", DepartmentName = "Research and Development", Salary = 3433 },
                new Core.Entities.Employee { Id = 957, GivenName = "Alexa", Surname = "Gibb", DepartmentName = "Research and Development", Salary = 3423 },
                new Core.Entities.Employee { Id = 446, GivenName = "Candy", Surname = "Caraher", DepartmentName = "Research and Development", Salary = 3415 },
                new Core.Entities.Employee { Id = 666, GivenName = "Cleo", Surname = "Skinn", DepartmentName = "Human Resources", Salary = 3495 },
                new Core.Entities.Employee { Id = 17, GivenName = "Thatch", Surname = "Loraine", DepartmentName = "Human Resources", Salary = 3478 },
                new Core.Entities.Employee { Id = 386, GivenName = "Frieda", Surname = "Smallbone", DepartmentName = "Human Resources", Salary = 3469 },
                new Core.Entities.Employee { Id = 919, GivenName = "Dun", Surname = "Auchinleck", DepartmentName = "Human Resources", Salary = 3466 },
                new Core.Entities.Employee { Id = 456, GivenName = "Law", Surname = "Shorto", DepartmentName = "Human Resources", Salary = 3441 },
                new Core.Entities.Employee { Id = 930, GivenName = "Joli", Surname = "Arnholtz", DepartmentName = "Support", Salary = 3493 },
                new Core.Entities.Employee { Id = 120, GivenName = "Jordan", Surname = "Finlan", DepartmentName = "Support", Salary = 3487 },
                new Core.Entities.Employee { Id = 581, GivenName = "Colly", Surname = "Derl", DepartmentName = "Support", Salary = 3476 },
                new Core.Entities.Employee { Id = 936, GivenName = "Margarita", Surname = "Gowen", DepartmentName = "Support", Salary = 3469 },
                new Core.Entities.Employee { Id = 816, GivenName = "Clarissa", Surname = "Gregolin", DepartmentName = "Support", Salary = 3461 },
                new Core.Entities.Employee { Id = 484, GivenName = "Wyn", Surname = "Woofendell", DepartmentName = "Training", Salary = 3497 },
                new Core.Entities.Employee { Id = 947, GivenName = "Daffi", Surname = "Brabbins", DepartmentName = "Training", Salary = 3470 },
                new Core.Entities.Employee { Id = 21, GivenName = "Barrett", Surname = "Boich", DepartmentName = "Training", Salary = 3466 },
                new Core.Entities.Employee { Id = 337, GivenName = "Bunnie", Surname = "Chiplen", DepartmentName = "Training", Salary = 3448 },
                new Core.Entities.Employee { Id = 966, GivenName = "Lauretta", Surname = "Tetther", DepartmentName = "Training", Salary = 3439 },
                new Core.Entities.Employee { Id = 346, GivenName = "Thedrick", Surname = "Gofforth", DepartmentName = "Services", Salary = 3491 },
                new Core.Entities.Employee { Id = 480, GivenName = "Scotty", Surname = "Cornelius", DepartmentName = "Services", Salary = 3473 },
                new Core.Entities.Employee { Id = 583, GivenName = "Paddie", Surname = "Martinolli", DepartmentName = "Services", Salary = 3438 },
                new Core.Entities.Employee { Id = 797, GivenName = "Mallory", Surname = "Abbott", DepartmentName = "Services", Salary = 3431 },
                new Core.Entities.Employee { Id = 128, GivenName = "Jock", Surname = "Miles", DepartmentName = "Services", Salary = 3429 },
                new Core.Entities.Employee { Id = 926, GivenName = "Gauthier", Surname = "Tippler", DepartmentName = "Product Management", Salary = 3487 },
                new Core.Entities.Employee { Id = 902, GivenName = "Domenic", Surname = "Mouland", DepartmentName = "Product Management", Salary = 3463 },
                new Core.Entities.Employee { Id = 742, GivenName = "Maura", Surname = "Attow", DepartmentName = "Product Management", Salary = 3445 },
                new Core.Entities.Employee { Id = 547, GivenName = "Finley", Surname = "Navarre", DepartmentName = "Product Management", Salary = 3437 },
                new Core.Entities.Employee { Id = 479, GivenName = "Dalt", Surname = "Dikle", DepartmentName = "Product Management", Salary = 3429 },
                new Core.Entities.Employee { Id = 603, GivenName = "Flinn", Surname = "Jillis", DepartmentName = "Marketing", Salary = 3476 },
                new Core.Entities.Employee { Id = 22, GivenName = "Rhiamon", Surname = "Barwood", DepartmentName = "Marketing", Salary = 3459 },
                new Core.Entities.Employee { Id = 11, GivenName = "Jay", Surname = "Orta", DepartmentName = "Marketing", Salary = 3451 },
                new Core.Entities.Employee { Id = 66, GivenName = "Genevra", Surname = "Morman", DepartmentName = "Marketing", Salary = 3447 },
                new Core.Entities.Employee { Id = 794, GivenName = "Matias", Surname = "MacPhail", DepartmentName = "Marketing", Salary = 3422 },
                new Core.Entities.Employee { Id = 477, GivenName = "Alfie", Surname = "Parke", DepartmentName = "Engineering", Salary = 3491 },
                new Core.Entities.Employee { Id = 228, GivenName = "Jaquith", Surname = "Tuiller", DepartmentName = "Engineering", Salary = 3487 },
                new Core.Entities.Employee { Id = 793, GivenName = "Terrill", Surname = "Cappell", DepartmentName = "Engineering", Salary = 3450 },
                new Core.Entities.Employee { Id = 166, GivenName = "Renell", Surname = "Atack", DepartmentName = "Engineering", Salary = 3438 },
                new Core.Entities.Employee { Id = 341, GivenName = "Sloane", Surname = "Santacrole", DepartmentName = "Engineering", Salary = 3430 },
                new Core.Entities.Employee { Id = 46, GivenName = "Anastasia", Surname = "Jacombs", DepartmentName = "Business Development", Salary = 3468 },
                new Core.Entities.Employee { Id = 262, GivenName = "Holmes", Surname = "Pyrah", DepartmentName = "Business Development", Salary = 3452 },
                new Core.Entities.Employee { Id = 16, GivenName = "Adria", Surname = "Galfour", DepartmentName = "Business Development", Salary = 3434 },
                new Core.Entities.Employee { Id = 13, GivenName = "Dionysus", Surname = "Aiton", DepartmentName = "Business Development", Salary = 3433 },
                new Core.Entities.Employee { Id = 450, GivenName = "Cicely", Surname = "Scirman", DepartmentName = "Business Development", Salary = 3424 },
                new Core.Entities.Employee { Id = 708, GivenName = "Sergei", Surname = "Sandwich", DepartmentName = "Sales", Salary = 3491 },
                new Core.Entities.Employee { Id = 83, GivenName = "Nicholle", Surname = "Risborough", DepartmentName = "Sales", Salary = 3475 },
                new Core.Entities.Employee { Id = 199, GivenName = "Dolorita", Surname = "Sheeran", DepartmentName = "Sales", Salary = 3463 },
                new Core.Entities.Employee { Id = 741, GivenName = "Thomasin", Surname = "Coverley", DepartmentName = "Sales", Salary = 3459 },
                new Core.Entities.Employee { Id = 734, GivenName = "Kristofer", Surname = "Pawfoot", DepartmentName = "Sales", Salary = 3455 },
                new Core.Entities.Employee { Id = 247, GivenName = "Eudora", Surname = "Vaney", DepartmentName = "TI", Salary = 3500 },
                new Core.Entities.Employee { Id = 886, GivenName = "Hendrick", Surname = "Molines", DepartmentName = "TI", Salary = 3494 },
                new Core.Entities.Employee { Id = 522, GivenName = "Brietta", Surname = "Cleaves", DepartmentName = "TI", Salary = 3482 },
                new Core.Entities.Employee { Id = 801, GivenName = "Charleen", Surname = "Mityashin", DepartmentName = "TI", Salary = 3482 },
                new Core.Entities.Employee { Id = 197, GivenName = "Warden", Surname = "Rosewell", DepartmentName = "TI", Salary = 3480 },
            };

            return Task.FromResult(result.AsEnumerable());
        }
    }
}
