using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Admin.Models;
namespace Admin.Controllers
{
    public class FacultyController : Controller
    {
        private readonly FacultyRepo _context;

        public FacultyController(FacultyRepo context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            bool isValid = _context.Login.Any(x => x.UserName == model.UserName && x.Password == model.Password);
            if (isValid)
            {
                return RedirectToAction(nameof(Admin));
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName and Password");
            }
            return View();
        }

        public IActionResult AcademyPortal()
        {
            return View();
        }
        public IActionResult FacultyRegistration()
        {
            return View();
        }
        public IActionResult BatchAllocations()
        {
            return View();
        }
        public IActionResult AwardandCreditpoint()
        {
            return View();
        }

        public IActionResult Admin()
        {
            
            return View();
        }
        public async Task<IActionResult> Index3()
        {
            return View(await _context.Faculty.ToListAsync());

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Faculty sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index3));
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index3");
            }
            var mod = await _context.Faculty.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Faculty sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index3");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> FactEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index3");
            }
            var mod = await _context.Faculty.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FactEdit(Faculty sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index3");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Faculty.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var sales = await _context.Faculty.FindAsync(id);
            _context.Faculty.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index3));
        }
        [HttpGet]
        public async Task<IActionResult> FactDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Faculty.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("FactDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FactDeleteConfirm(int id)
        {
            var sales = await _context.Faculty.FindAsync(id);
            _context.Faculty.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index3));
        }

    

public async Task<IActionResult> Index4()
        {
            return View(await _context.FacultySkill.ToListAsync());

        }

        public IActionResult Create1()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create1(FacultySkill sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index4));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit1(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index4");
            }
            var mod = await _context.FacultySkill.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit1(FacultySkill sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index4");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> FactEdit1(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index4");
            }
            var mod = await _context.FacultySkill.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FactEdit1(FacultySkill sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index4");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete1(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.FacultySkill.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete1")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm1(int id)
        {
            var sales = await _context.FacultySkill.FindAsync(id);
            _context.FacultySkill.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index4));
        }
        [HttpGet]
        public async Task<IActionResult> FactDelete1(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.FacultySkill.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("FactDelete1")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FactDeleteConfirm1(int id)
        {
            var sales = await _context.Faculty.FindAsync(id);
            _context.Faculty.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index4));
        }

        public async Task<IActionResult> Module()
        {
            return View(await _context.Module.ToListAsync());

        }
        public IActionResult Create2()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create2(Module sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Module));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit2(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Module");
            }
            var mod = await _context.Module.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit2(Module sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Module");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> ModEdit2(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Module");
            }
            var mod = await _context.Module.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModEdit2(Module sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Module");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete2(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Module.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete2")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm2(int id)
        {
            var sales = await _context.Module.FindAsync(id);
            _context.Module.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Module));
        }
        [HttpGet]
        public async Task<IActionResult> ModDelete2(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Module.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("ModDelete2")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModDeleteConfirm2(int id)
        {
            var sales = await _context.Module.FindAsync(id);
            _context.Module.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Module));
        }
        public async Task<IActionResult> Batch()
        {
            return View(await _context.Batch.ToListAsync());

        }
        public IActionResult create3()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create3(Batch sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Batch));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit3(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Batch");
            }
            var mod = await _context.Batch.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit3(Batch sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Batch");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> ModEdit3(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Batch");
            }
            var mod = await _context.Batch.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModEdit3(Batch sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Batch");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete3(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Batch.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete3")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm3(int id)
        {
            var sales = await _context.Batch.FindAsync(id);
            _context.Batch.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Batch));
        }
        [HttpGet]
        public async Task<IActionResult> ModDelete3(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Batch.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("ModDelete3")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModDeleteConfirm3(int id)
        {
            var sales = await _context.Batch.FindAsync(id);
            _context.Batch.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Batch));
        }
        public async Task<IActionResult> Batchupdate()
        {
            return View(await _context.Batchupdate.ToListAsync());

        }
        public IActionResult create4()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create4(Batchupdate sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Batchupdate));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit4(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Batchupdate");
            }
            var mod = await _context.Batchupdate.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit4(Batchupdate sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Batchupdate");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> ModEdit4(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Batchupdate");
            }
            var mod = await _context.Batchupdate.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModEdit4(Batchupdate sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Batchupdate");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete4(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Batchupdate.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete4")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm4(int id)
        {
            var sales = await _context.Batchupdate.FindAsync(id);
            _context.Batchupdate.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Batchupdate));
        }
        [HttpGet]
        public async Task<IActionResult> ModDelete4(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Batchupdate.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("ModDelete4")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModDeleteConfirm4(int id)
        {
            var sales = await _context.Batchupdate.FindAsync(id);
            _context.Batchupdate.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Batchupdate));
        }
        public async Task<IActionResult> Report()
        {
            return View(await _context.Report.ToListAsync());

        }
        public IActionResult create5()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create5(Report sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Report));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit5(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Report");
            }
            var mod = await _context.Report.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit5(Report sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Report");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> ModEdit5(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Report");
            }
            var mod = await _context.Report.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModEdit5(Report sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Report");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete5(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Report.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete5")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm5(int id)
        {
            var sales = await _context.Report.FindAsync(id);
            _context.Report.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Report));
        }
        [HttpGet]
        public async Task<IActionResult> ModDelete5(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Report.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("ModDelete5")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModDeleteConfirm5(int id)
        {
            var sales = await _context.Report.FindAsync(id);
            _context.Report.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Report));
        }
        public async Task<IActionResult> Award()
        {
            return View(await _context.Award.ToListAsync());

        }
        public IActionResult create6()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create6(Award sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Award));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit6(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Award");
            }
            var mod = await _context.Award.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit6(Award sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Award");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> ModEdit6(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Award");
            }
            var mod = await _context.Award.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModEdit6(Award sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("Award");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete6(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Award.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete6")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm6(int id)
        {
            var sales = await _context.Award.FindAsync(id);
            _context.Award.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Award));
        }
        [HttpGet]
        public async Task<IActionResult> ModDelete6(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Award.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("ModDelete6")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModDeleteConfirm6(int id)
        {
            var sales = await _context.Award.FindAsync(id);
            _context.Award.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Award));
        }
        public async Task<IActionResult> credit()
        {
            return View(await _context.Credit.ToListAsync());

        }
        public IActionResult create7()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create7(Credit sales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Submit));
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Edit7(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("credit");
            }
            var mod = await _context.Credit.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit7(Credit sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("credit");
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> ModEdit7(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("credit");
            }
            var mod = await _context.Credit.FindAsync(id);
            return View(mod);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModEdit7(Award sales)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sales);
                await _context.SaveChangesAsync();
                return RedirectToAction("credit");
            }
            return View(sales);
        }
        [HttpGet]
        public async Task<IActionResult> Delete7(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Credit.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("Delete7")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm7(int id)
        {
            var sales = await _context.Credit.FindAsync(id);
            _context.Credit.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(credit));
        }
        [HttpGet]
        public async Task<IActionResult> ModDelete7(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sales = await _context.Credit.FirstAsync(m => m.Faculty_Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            return View(sales);
        }
        [HttpPost, ActionName("ModDelete7")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModDeleteConfirm7(int id)
        {
            var sales = await _context.Credit.FindAsync(id);
            _context.Credit.Remove(sales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(credit));
        }

        public IActionResult Submit()

        {

            RedirectToAction(nameof(Submit));
            return View();
        }
       
    }

}



    


       

      
        
        

