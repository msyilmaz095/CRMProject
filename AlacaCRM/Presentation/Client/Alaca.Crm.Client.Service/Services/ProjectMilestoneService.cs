
using System.Net.Http;
using System.Threading.Tasks;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using System;
using System.Net.Http.Json;
using Alaca.Entities.Dto;
using Alaca.Core.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Alaca.Crm.Client.Service.Services
{
    public class ProjectMilestoneService : IProjectMilestoneService
    {
        HttpClient _httpClient;
        public ProjectMilestoneService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> Delete(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/{nameof(ProjectMilestone)}/delete?id={id}");
            return await response.ToResultAsync();
        }

        public async Task<IResultData<ProjectMilestone[]>> GetAll()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestone)}/GetAll");
            return await response.ToResultAsync<ProjectMilestone[]>();
        }

        public async Task<List<GanttDataRecord>> GetByGanttDataRecord()
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestone)}/GetAll");
            var data = (await response.ToResultAsync<ProjectMilestone[]>()).Data;
            var lst= data.Select(col => new GanttDataRecord()
            {
                Class = "release-team",
                Type = "task",
                Label = col.ProjectMilestoneName,
                DateStart = string.Format("{0:yyyy-MM-dd}", col.MilestoneTargetStartDate),
                DateEnd = string.Format("{0:yyyy-MM-dd}", col.MilestoneTargetFinishDate)
            }).ToArray();
            return lst.ToList();
        }

        public async Task<IResultData<ProjectMilestone>> GetById(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestone)}/GetById?id={id}");
            return await response.ToResultAsync<ProjectMilestone>();
        }

        public async Task<IResultData<viewProjectMilestone[]>> GetByProjectIdProjectMilestone(Guid ProjectId)
        {
            var response = await _httpClient.GetAsync($"api/{nameof(ProjectMilestone)}/GetByProjectIdProjectMilestone?ProjectId={ProjectId}");
            return await response.ToResultAsync<viewProjectMilestone[]>();
        }

        public async Task<IResult> Insert(ProjectMilestone data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ProjectMilestone)}/insert", data);
            return await response.ToResultAsync();
        }

        public async Task<IResult> Update(ProjectMilestone data)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/{nameof(ProjectMilestone)}/update", data);
            return await response.ToResultAsync();
        }
    }
}

