using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoMerck.Models.Entities;
using ProyectoMerck.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMerck.Models.ViewModels
{
    public class ConsultationViewModel
    {
        [Display(Name = "Country", ResourceType = typeof(ValidationResources))]
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ValidationResources))]
        public string? Country { get; set; }

        [Display(Name = "Province", ResourceType = typeof(ValidationResources))]
        public string? Province { get; set; }

        [Display(Name = "Location", ResourceType = typeof(ValidationResources))]
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ValidationResources))]
        public string? Location { get; set; }

        [Display(Name = "ReasonConsultation", ResourceType = typeof(ValidationResources))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ValidationResources))]
        public string? ReasonConsultation { get; set; }

        [Display(Name = "Clinic", ResourceType = typeof(ValidationResources))]
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ValidationResources))]
        public string? Clinic { get; set; } = null;

        [Display(Name = "Email", ResourceType = typeof(ValidationResources))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ValidationResources))]
        [EmailAddress(ErrorMessageResourceName = "Email", ErrorMessageResourceType = typeof(ValidationResources))]
        public string? Email { get; set; }

        [Display(Name = "DateAndTime", ResourceType = typeof(ValidationResources))]
        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ValidationResources))]
        [DataType(DataType.DateTime, ErrorMessage = "InvalidDateTimeFormat", ErrorMessageResourceType = typeof(ValidationResources))]
        public DateTime DateAndtime { get; set; }

        [Display(Name = "URL", ResourceType = typeof(ValidationResources))]
        public string? Url { get; set; } = null;

        public string? Locations { get; set; }


        public int SelectedCountry { get; set; }
        public int SelectedProvince { get; set; }
        public int SelectedProvinceLocation { get; set; }
        public int SelectedLocationIndex { get; set; }
        public bool SubmitError { get; set; }

        public List<Province> ProvincList { get; set; } = new List<Province>();
        public List<Location> LocationsList { get; set; } = new List<Location>();
        public List<ProvinceLocation> ProvinceLocationList { get; set; } = new List<ProvinceLocation>();
        public List<Country> CountryList { get; set; } = new List<Country>();



    }
}
    