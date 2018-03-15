using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel 
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel
        if JobField.JobFieldsViews = JobField.BaseViewModel //If the field is common to the JobFields View Model,
            add.JobField.BaseViewModel; //Add the field to the BaseView Model. Otherwise, move to the next item in the job field.

        // The search results
        public List<Job> Jobs { get; set; }

        // The column to search, defaults to all
        public JobFieldType Column { get; set; } = JobFieldType.All;

        // The search value
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // View title
        public string Title { get; set; } = "";

        public SearchJobsViewModel()
        {
            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }


        }
    }
}
