using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WestcoastEducation.Web.ViewModels.Classrooms;

public class ClassroomPostViewModel
{
    [Required(ErrorMessage = "Kursnummer är obligatoriskt")]
    [DisplayName("Kursnummer")]
    public string Number { get; set; } = "";

    [Required(ErrorMessage = "Kursnamn är obligatoriskt")]
    [DisplayName("Kursnamn")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Lärare är obligatoriskt")]
    [DisplayName("Lärare")]
    public string Teacher { get; set; }

    [Required(ErrorMessage = "Kurstitel är obligatoriskt")]
    [DisplayName("Kurstitel")]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "Kursinnehåll är obligatoriskt")]
    [DisplayName("Kursinnehåll (separera med '|')")]
    public string Content { get; set; } = "";

    [Required(ErrorMessage = "Startdatum är obligatoriskt")]
    [DisplayName("Startdatum")]
    public DateTime Start { get; set; }

    [Required(ErrorMessage = "Slutdatum är obligatoriskt")]
    [DisplayName("Slutdatum")]
    public DateTime End { get; set; }

    [Required(ErrorMessage = "Status är obligatoriskt")]
    [DisplayName("Status")]
    public string Status { get; set; }

    [DisplayName("Är kursen på distans?")]
    public bool IsOnDistance { get; set; }

    public List<SelectListItem> Teachers { get; set; }
    public List<SelectListItem> StatusList
    {
        get
        {
            return new List<SelectListItem>()
            {
                new SelectListItem {Value = "0", Text = "Ingen Status"},
                new SelectListItem {Value = "1", Text = "Kommande"},
                new SelectListItem {Value = "2", Text = "Öppen för ansökan"},
                new SelectListItem {Value = "3", Text = "Fullbokad"},
                new SelectListItem {Value = "4", Text = "Stängd för ansökan"},
                new SelectListItem {Value = "5", Text = "Pågående"},
                new SelectListItem {Value = "6", Text = "Avslutad"}
            };
        }
    }
}
