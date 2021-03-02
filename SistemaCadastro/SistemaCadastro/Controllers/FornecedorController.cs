using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Data;
using SistemaCadastro.Models;

namespace SistemaCadastro.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly Context _context;

        public FornecedorController(Context context)
        {
            _context = context;
        }

        // GET: Fornecedor
        public async Task<IActionResult> Index()
        {
            return View(await _context.FornecedorModel.ToListAsync());
        }

        // GET: Fornecedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedorModel = await _context.FornecedorModel
                .FirstOrDefaultAsync(m => m.FornecedorId == id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }

            return View(fornecedorModel);
        }

        // GET: Fornecedor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FornecedorId,NomeFantasia,Cnpj,Endereco,Email")] FornecedorModel fornecedorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorModel);
        }

        // GET: Fornecedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedorModel = await _context.FornecedorModel.FindAsync(id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }
            return View(fornecedorModel);
        }

        // POST: Fornecedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FornecedorId,NomeFantasia,Cnpj,Endereco,Email")] FornecedorModel fornecedorModel)
        {
            if (id != fornecedorModel.FornecedorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorModelExists(fornecedorModel.FornecedorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorModel);
        }

        // GET: Fornecedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedorModel = await _context.FornecedorModel
                .FirstOrDefaultAsync(m => m.FornecedorId == id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }

            return View(fornecedorModel);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fornecedorModel = await _context.FornecedorModel.FindAsync(id);
            _context.FornecedorModel.Remove(fornecedorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorModelExists(int id)
        {
            return _context.FornecedorModel.Any(e => e.FornecedorId == id);
        }
    }
}
