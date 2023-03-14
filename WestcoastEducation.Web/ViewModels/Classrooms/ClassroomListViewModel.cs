namespace WestcoastEducation.Web.ViewModels.Classrooms;

public class ClassroomListViewModel
{
    public int Id { get; set; }
    public string Number { get; set; } = "";
    public string Name { get; set; } = "";
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public TimeSpan Length { get => End - Start; }
    public int Status { get; set; }
    public bool IsOnDistance { get; set; } = false;

    public string GetStatus
    {
        get
        {
            switch (Status)
            {
                case 0:
                    return "Ingen status";
                case 1:
                    return "Kommande";
                case 2:
                    return "Öppen för ansökan";
                case 3:
                    return "Fullbokad";
                case 4:
                    return "Stängd för ansökan";
                case 5:
                    return "Pågående";
                case 6:
                    return "Avslutad";
                default:
                    return "FEL KOD";
            }
        }
    }
}