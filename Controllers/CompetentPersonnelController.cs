﻿using BLMS.Context;
using BLMS.Models.SOP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLMS.Controllers
{
    public class CompetentPersonnelController : Controller
    {
        private readonly CompetentDBContext _context;

        public CompetentPersonnelController(CompetentDBContext context)
        {
            _context = context;
        }

        // GET: CompetentPersonnel
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblCompetentPersonnel.ToListAsync());
        }

        // GET: CompetentPersonnel/Details/5
        public async Task<IActionResult> Details(int? id, string m)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competentPersonnel = await _context.TblCompetentPersonnel
                .FirstOrDefaultAsync(m => m.PersonnelId == id);
            if (competentPersonnel == null)
            {
                return NotFound();
            }

            // Add successful message
            string returnMessage = m switch
            {
                // Add successful message       
                "registered" => GenerateAlertMessage("success", "", "Registration is successful."),//type, title, msg
                // Add not successful message
                "notregistered" => GenerateAlertMessage("danger", "", "Registration is not successful."),//type, title, msg
                _ => "",
            };

            // Update page Competent Personnel data
            PageCompetentPersonnel pCompetentPersonnel = new PageCompetentPersonnel { CompetentPersonnel = competentPersonnel, ReturnMessage = returnMessage };

            return View(pCompetentPersonnel);
        }

        // GET: CompetentPersonnel/Register
        public IActionResult Register()
        {
            // Update page Competent Personnel data
            PageCompetentPersonnel pCompetentPersonnel = new PageCompetentPersonnel { CompetentPersonnel = new CompetentPersonnel() };

            return View(pCompetentPersonnel);
        }

        // POST: CompetentPersonnel/Register
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("PersonnelId,PersonnelName,Icno,AppointedDt,CertFrom,CertType,CertNo,ExpiredDt,YearAwarded,CertFileName,RegNo,Branch,CreatedDt,CreatedBy,UpdatedDt,UpdatedBy,BusinessDiv,BusinessUnit")] CompetentPersonnel competentPersonnel)
        {
            string returnMessageCode;

            if (ModelState.IsValid)
            {
                // Update data
                competentPersonnel.CreatedDt = DateTime.Now;
                // TODO competentPersonnel.CreatedBy
                competentPersonnel.UpdatedDt = DateTime.Now;
                // TODO competentPersonnel.UpdatedBy

                _context.Add(competentPersonnel);
                await _context.SaveChangesAsync();

                // Add successful message
                returnMessageCode = "registered";
            }
            else
            {
                // Add not successful message
                returnMessageCode = "notregistered";
            }

            return RedirectToAction("Details", new { id = competentPersonnel.PersonnelId, m = returnMessageCode });
        }

        // GET: CompetentPersonnel/Renewal/5
        public async Task<IActionResult> Renewal(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competentPersonnel = await _context.TblCompetentPersonnel.FindAsync(id);
            if (competentPersonnel == null)
            {
                return NotFound();
            }

            // Update page Competent Personnel data
            PageCompetentPersonnel pCompetentPersonnel = new PageCompetentPersonnel { CompetentPersonnel = competentPersonnel };

            return View(pCompetentPersonnel);
        }

        // POST: CompetentPersonnel/Renewal/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Renewal(int id, [Bind("PersonnelId,PersonnelName,Icno,AppointedDt,CertFrom,CertType,CertNo,ExpiredDt,YearAwarded,CertFileName,RegNo,Branch,CreatedDt,CreatedBy,UpdatedDt,UpdatedBy,BusinessDiv,BusinessUnit")] CompetentPersonnel competentPersonnel)
        {
            string returnMessage = "";

            if (id != competentPersonnel.PersonnelId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    // Update data
                    competentPersonnel.UpdatedDt = DateTime.Now;
                    // TODO competentPersonnel.UpdatedBy

                    _context.Update(competentPersonnel);
                    await _context.SaveChangesAsync();

                    // Add successful message
                    returnMessage = GenerateAlertMessage("success", "", "Renewal is successfully updated."); //type, title, msg
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Add not successful message
                    returnMessage = GenerateAlertMessage("danger", "", "Renewal is not successful."); //type, title, msg

                    if (!CompetentPersonnelExists(competentPersonnel.PersonnelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
            }

            // Update page Competent Personnel data
            PageCompetentPersonnel pCompetentPersonnel = new PageCompetentPersonnel { CompetentPersonnel = competentPersonnel, ReturnMessage = returnMessage };

            return View(pCompetentPersonnel);
        }

        // GET: CompetentPersonnel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competentPersonnel = await _context.TblCompetentPersonnel
                .FirstOrDefaultAsync(m => m.PersonnelId == id);
            if (competentPersonnel == null)
            {
                return NotFound();
            }

            return View(competentPersonnel);
        }

        // POST: CompetentPersonnel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competentPersonnel = await _context.TblCompetentPersonnel.FindAsync(id);
            _context.TblCompetentPersonnel.Remove(competentPersonnel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetentPersonnelExists(int id)
        {
            return _context.TblCompetentPersonnel.Any(e => e.PersonnelId == id);
        }

        private string GenerateAlertMessage(string type, string title, string msg) // type:success/info/danger/warning
        {
            string icon = "info";

            switch (type)
            {
                case "success":
                    icon = "check";
                    break;

                case "danger":
                case "warning":
                    icon = "exclamation-triangle";
                    break;

            }
            string alertMsg = "<div class=\"callout callout-" + type + " callout-dismissible\">" +
                "<button type = \"button\" class=\"close\" data-dismiss=\"callout\" aria-hidden=\"true\">&times;</button>" +
                "<i class=\"icon fas fa-" + icon + " text-" + type + "\"></i>&nbsp;" + msg + "</div>";

            //string alertMsg = "<div class=\"alert alert-" + icon + " alert-dismissible\">" +
            //    "<button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>" +
            //    "<h5><i class=\"icon fas fa-check\"></i>" + title + "</h5>" + msg +
            //    "</button></div>";

            //string alertMsg = "<script type=\"text/javascript\">" +
            //    "$(document).ready(function () {showSwalToast('" + icon + "','" + title + "','" + msg + "')})" +
            //    "</script>";            

            return alertMsg;
        }
    }
}
