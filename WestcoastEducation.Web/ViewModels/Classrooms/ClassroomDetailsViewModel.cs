using System.ComponentModel;
using WestcoastEducation.Web.ViewModels.Users;

namespace WestcoastEducation.Web.ViewModels.Classrooms;

public class ClassroomDetailsViewModel
{
    [DisplayName("KursID")]
    public int Id { get; set; }

    [DisplayName("Lärare")]
    public string Teacher { get; set; }

    [DisplayName("Kursnummer")]
    public string Number { get; set; } = "";

    [DisplayName("Kursnamn")]
    public string Name { get; set; } = "";

    [DisplayName("Kurstitel")]
    public string Title { get; set; } = "";

    [DisplayName("Startdatum")]
    public DateTime Start { get; set; }

    [DisplayName("Slutdatum")]
    public DateTime End { get; set; }

    [DisplayName("Kurslängd")]
    public TimeSpan Length { get => End - Start; }

    [DisplayName("Status")]
    public string Status { get; set; }

    [DisplayName("Kursinnehåll")]
    public string Content { get; set; } = "";

    [DisplayName("På distans?")]
    public bool IsOnDistance { get; set; } = false;

    public string[] GetContentList
    {
        get
        {
            string[] contentList = Content.Split('|');
            return contentList;
        }
    }

    [DisplayName("Studenter")]
    public ICollection<UserListViewModel> Students { get; set; }

        public string GetStatusInSwedish
    {
        get
        {
            switch (Status)
            {
                case "NoStatus":
                    return "Ingen status";
                case "Upcoming":
                    return "Kommande";
                case "OpenForRegistration":
                    return "Öppen för ansökan";
                case "FullyBooked":
                    return "Fullbokad";
                case "CloseForRegistration":
                    return "Stängd för ansökan";
                case "Ongoing":
                    return "Pågående";
                case "Completed":
                    return "Avslutad";
                default:
                    return "FEL KOD";
            }
        }
    }
}