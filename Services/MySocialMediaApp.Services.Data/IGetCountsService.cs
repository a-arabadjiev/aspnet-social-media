namespace MySocialMediaApp.Services.Data
{
    using MySocialMediaApp.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        IndexViewModel GetCounts();
    }
}
