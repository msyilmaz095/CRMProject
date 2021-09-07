using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Entities.Dto;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages
{
    public partial class Index
    {
        [Inject] public IProjectService _projectService { get; set; }
        [Inject] public ISalesOfferService _salesOfferService { get; set; }
        [Inject] public IActivityService _activityService { get; set; }
        viewProject[] projects;
        viewProject[] Top10projects;
        viewActivity[] monthlyActivities;
        viewActivity[] activities;
        viewSalesOffer[] Top10viewSalesOffers;
        viewSalesOffer[] viewSalesOffers;
        viewSalesOffer[] monthlyviewSalesOffers;
        public string[] InputChartLabel { get; set; }
        public double[] InputChartValue { get; set; }
        DateTime StartDate = DateTime.Now.Date, EndDate = DateTime.Now.Date.AddHours(23).AddMinutes(59);
        DateTime monthlyStartDate;
        DateTime monthlyEndDate;
       
        protected override void OnParametersSet()
        {
        }
        protected async override Task OnInitializedAsync()
        {
            monthlyStartDate = new DateTime(EndDate.Year, EndDate.Month, 1);
            monthlyEndDate = monthlyStartDate.AddMonths(1).AddDays(-1);
            projects = (await _projectService.GetByDateTimeBetweenviewProjects(StartDate, EndDate)).Data;
            Top10projects = (await _projectService.GetOrderDescTop10viewProjects()).Data;
            Top10viewSalesOffers = (await _salesOfferService.GetOrderDescTop10viewSalesOffers()).Data;
            viewSalesOffers = (await _salesOfferService.GetByDateTimeBetweenviewSalesOffers(StartDate, EndDate)).Data;
            monthlyviewSalesOffers = (await _salesOfferService.GetByDateTimeBetweenviewSalesOffers(monthlyStartDate, monthlyEndDate)).Data;
            activities = (await _activityService.GetByDateBetweenviewActivities(StartDate, EndDate, Guid.Empty)).Data;
            monthlyActivities = (await _activityService.GetByDateBetweenviewActivities(monthlyStartDate, monthlyEndDate, Guid.Empty)).Data;
            var lst = monthlyActivities?.GroupBy(grp => grp.ActivityTypeName).Select(col =>new { ActivityTypeName = col.Key,Count=col.Count() }).ToArray();
            InputChartValue = new double[lst.Length];
            InputChartLabel = new string[lst.Length];
            for (int i = 0; i < lst.Length; i++)
            {
                InputChartLabel[i] = lst[i].ActivityTypeName;
                InputChartValue[i] = lst[i].Count;
            }
        }
    }
}
