using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;

namespace EnergyController.Services.Controladores
{
    public class ContReportR: SQLRepository<ReportRoute>, IRepositoryReportR
    {
        public ContReportR(AppDBContext context) : base(context) { }
        public int InsertRR(ReportRoute reportRoute)
        {
            if (reportRoute == null) throw new ArgumentNullException("Entity");
            entities.Add(reportRoute);
            context.SaveChanges();
            return reportRoute.Id;
        }
        public IEnumerable<ReportRoute> GetReportRoutes()
        {
            return context.Set<ReportRoute>().AsEnumerable();
        }
    }
}
