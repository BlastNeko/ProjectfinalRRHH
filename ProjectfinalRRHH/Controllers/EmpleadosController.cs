﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectfinalRRHH.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ProjectfinalRRHH.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly GestionRHContext _context;

        public EmpleadosController(GestionRHContext context)
        {
            _context = context;
        }

        // GET: MantenimientoEmpleados
        public async Task<IActionResult> Index()
        {
            return View(await _context.MantenimientoEmpleado.ToListAsync());
        }
        //get empleados inactivos
        public async Task<IActionResult> Inactivo()
        {
            return View(await _context.MantenimientoEmpleado.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Inactivo(string fecha0)
        {
            var nombres = from s in _context.ProcessSalidaEmpleado
                          select s;
            if (!String.IsNullOrEmpty(fecha0))
            {
                fecha0 = null;
            }
            else
            {
                DateTime fechax = DateTime.Parse(fecha0);
                nombres = nombres.Where(s => s.Empleado.Equals(fechax) || s.Fecha.Equals(fechax) || fechax == null);
            }

            return View(await nombres.AsNoTracking().ToListAsync());

        }

        //busqueda por nombre y fecha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string busqueda, string fecha)
        {
            var nombres = from s in _context.MantenimientoEmpleado
                          select s;
            if (!String.IsNullOrEmpty(busqueda))
            {
                nombres = nombres.Where(s => s.Nombre.Contains(busqueda));
            }
            else if (!String.IsNullOrEmpty(fecha))
            {
                nombres = nombres.Where(s => s.Departamento.Contains(fecha));
            }

            return View(await nombres.AsNoTracking().ToListAsync());
        }

        // GET: MantenimientoEmpleadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mantenimientoEmpleado = await _context.MantenimientoEmpleado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mantenimientoEmpleado == null)
            {
                return NotFound();
            }

            return View(mantenimientoEmpleado);
        }

        // GET: MantenimientoEmpleadoes/Create
        public IActionResult Create()
        {
            //obtener todos los departamentos
            List<string> departamentos = new List<string>();
            var vd = _context.MantenimientoDepartamento.ToList();
            foreach (var item in vd)
            {
                departamentos.Add(item.Nombre);
                ViewBag.deps = departamentos;
            }
            //obtener todos los cargos
            List<string> cargos = new List<string>();
            var vc = _context.MantenimientoCargo.ToList();
            foreach (var item in vc)
            {
                cargos.Add(item.NombreCargo);
                ViewBag.carg = cargos;
            }

            return View();
        }

        // POST: MantenimientoEmpleadoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoEmpleado,Nombre,Apellido,Telefono,Departamento,FechaIngreso,Salario,Estatus,Cargo")] MantenimientoEmpleado empleado)
        {

            if (ModelState.IsValid)
            {
                empleado.Estatus = true;
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: MantenimientoEmpleadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mantenimientoEmpleado = await _context.MantenimientoEmpleado
                .FindAsync(id);
            if (mantenimientoEmpleado == null)
            {
                return NotFound();
            }
            return View(mantenimientoEmpleado);
        }

        // POST: MantenimientoEmpleadoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoEmpleado,Nombre,Apellido,Telefono,Departamento,FechaIngreso,Salario,Estatus,Cargo")] MantenimientoEmpleado mantenimientoEmpleado)
        {
            if (id != mantenimientoEmpleado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mantenimientoEmpleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MantenimientoEmpleadoExists(mantenimientoEmpleado.Id))
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
            return View(mantenimientoEmpleado);
        }

        //mostrar monto total en bdd
        public IActionResult NominaTotal(ProcessNominas p)
        {
            p.Mes = DateTime.Today.Month;
            p.Age = DateTime.Now.Year;
            var nom = from m in _context.MantenimientoEmpleado where (m.Estatus == true) select m.Salario;
            p.MontoTotal = nom.Sum();
            return View(p);
        }
        //muestra la tabla process nomina
        public async Task<IActionResult> NM()
        {
            return View(await _context.ProcessNominas.ToListAsync());
        }
        //busqueda por fecha de las nominas
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NM(string fechanom, string fechaye)
        {
            var nombres = from s in _context.ProcessNominas
                          select s;

            if (!String.IsNullOrEmpty(fechanom))
            {
                int fechax = Int32.Parse(fechanom);
                nombres = nombres.Where(s => s.Mes == fechax);
            }

            return View(await nombres.AsNoTracking().ToListAsync());
        }

        //guarda el monto total de la nomina en la base de datos
        public async Task<IActionResult> GuardarRegistro(ProcessNominas p)
        {
            p.Mes = DateTime.Today.Month;
            p.Age = DateTime.Now.Year;
            var nom = from m in _context.MantenimientoEmpleado where (m.Estatus == true) select m.Salario;
            p.MontoTotal = nom.Sum();
            _context.Add(p);
            await _context.SaveChangesAsync();

            return View(p);
        }

        //Registrar Vacaciones para empleados
        public IActionResult Vacaciones()
        {
            List<string> empleados = new List<string>();
            var vd = from em in _context.MantenimientoEmpleado where (em.Estatus == true) select em;
            foreach (var item in vd)
            {
                empleados.Add(item.Nombre + " " + item.Apellido);
                ViewBag.empvacaciones = empleados;
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //procesar las vacaciones en la bdd
        public async Task<IActionResult> Vacaciones([Bind("Id,Empleado,Desde,Hasta,Correspondiente,Comentario")] ProcessVacaciones vacaciones)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(vacaciones);
                    //_context.Update(empleado);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View("FallosVacaciones");
        }
        //Registrar Permisos para empleados
        public IActionResult Permisos()
        {
            List<string> empleados = new List<string>();
            var vd = from em in _context.MantenimientoEmpleado where (em.Estatus == true) select em;
            foreach (var item in vd)
            {
                empleados.Add(item.Nombre + " " + item.Apellido);
                ViewBag.emppermisos = empleados;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //procesar los permisos en la bdd
        public async Task<IActionResult> Permisos([Bind("Id,Empleado,Desde,Hasta,Comentario")] ProcessPermisos permisos)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(permisos);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View("FallosPermisos");
        }

        //Registrar Licencias para empleados
        public IActionResult Licencias()
        {
            List<string> empleados = new List<string>();
            var vd = from em in _context.MantenimientoEmpleado where (em.Estatus == true) select em;
            foreach (var item in vd)
            {
                empleados.Add(item.Nombre + " " + item.Apellido);
                ViewBag.emplicencias = empleados;
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //procesar los permisos en la bdd
        public async Task<IActionResult> Licencias([Bind("Id,Empleado,Desde,Hasta,Comentario,Motivo")] ProcessLicencias licencias)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(licencias);
                    //_context.Update(empleado);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View("FallosLicencias");
        }

        //mostrar Vacaciones
        public async Task<IActionResult> Vacacionesx()
        {
            return View(await _context.ProcessVacaciones.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Vacacionesx(string fecha2)
        {
            var nombres = from s in _context.ProcessVacaciones
                          select s;
            if (!String.IsNullOrEmpty(fecha2))
            {
                DateTime fechax = DateTime.Parse(fecha2);
                nombres = nombres.Where(s => s.Desde.Equals(fechax) || s.Hasta.Equals(fechax) || fechax == null);
            }

            return View(await nombres.AsNoTracking().ToListAsync());

        }

        //mostrar licencias
        public async Task<IActionResult> Licenciasx()
        {
            return View(await _context.ProcessLicencias.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Licenciasx(string fecha3)
        {
            var nombres = from s in _context.ProcessLicencias
                          select s;
            if (!String.IsNullOrEmpty(fecha3))
            {
                DateTime fechax = DateTime.Parse(fecha3);
                nombres = nombres.Where(s => s.Desde.Equals(fechax) || s.Hasta.Equals(fechax) || fechax == null);
            }

            return View(await nombres.AsNoTracking().ToListAsync());

        }

        //mostrar Permisos
        public async Task<IActionResult> Permisosx()
        {
            return View(await _context.ProcessPermisos.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Permisosx(string fecha4)
        {
            var nombres = from s in _context.ProcessPermisos
                          select s;
            if (!String.IsNullOrEmpty(fecha4))
            {
                DateTime fechax = DateTime.Parse(fecha4);
                nombres = nombres.Where(s => s.Desde.Equals(fechax) || s.Hasta.Equals(fechax) || fechax == null);
            }

            return View(await nombres.AsNoTracking().ToListAsync());

        }

        //registrar fallos
        public IActionResult FallosPermisos()
        {
            return View();
        }
        public IActionResult FallosVacaciones()
        {
            return View();
        }
        public IActionResult FallosLicencias()
        {
            return View();
        }


        //comprueba si los id de las tablas a mostrar existen
        private bool MantenimientoEmpleadoExists(int id)
        {
            return _context.MantenimientoEmpleado.Any(e => e.Id == id);
        }
    }
}