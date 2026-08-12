using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortfolioSite.Pages;

public class SystemProject
{
    public string Number { get; set; } = "";
    public string Name { get; set; } = "";
    public string Summary { get; set; } = "";
    public string[] Tags { get; set; } = Array.Empty<string>();
    public string? Url { get; set; }
    public string? Logo { get; set; }
}

public class WebsiteProject
{
    public string Name { get; set; } = "";
    public string Client { get; set; } = "";
    public string? Url { get; set; }
    public string Status { get; set; } = "Live";
}

public class Publication
{
    public string Title { get; set; } = "";
    public string Type { get; set; } = "";
    public string Url { get; set; } = "";
}

public class IndexModel : PageModel
{
    public List<SystemProject> Systems { get; } = new()
    {
        new SystemProject
        {
            Number = "01", Name = "YoPas", Logo = "yopas-logo.png",
            Summary = "Online ticketing platform for events of every kind. Organizers create events and sell tickets via mobile money, with automatic reconciliation, analytics and accountability reporting.",
            Tags = new[] { "ASP.NET Core", "Mobile Money API", "Analytics" },
            Url = "https://yopas.co.ug/"
        },
        new SystemProject
        {
            Number = "02", Name = "Etag", Logo = "etag-logo.png",
            Summary = "Guest management system. Attendees submit their details online and the system generates invitation cards or gate-access passes, with insights and card-procurement payments built in.",
            Tags = new[] { "ASP.NET Core", "Razor Pages", "Payments" }
        },
        new SystemProject
        {
            Number = "03", Name = "EGMS",
            Summary = "Full event guest management system for conferences, trade shows and exhibitions. Attendees register online and receive an NFC-enabled access card that doubles as a business card, remotely managed for status and announcements.",
            Tags = new[] { "NFC", "ASP.NET Core", "Event Ops" }
        },
        new SystemProject
        {
            Number = "04", Name = "Merch Manager",
            Summary = "Stock and inventory tool built for a fashion brand to manage event merchandise and generate barcodes for each item.",
            Tags = new[] { "Inventory", "Barcode Generation" }
        },
        new SystemProject
        {
            Number = "05", Name = "GIS Web Mapping",
            Summary = "Land-surveying and GIS platform built for churches across Greater Masaka. Converts field survey data, uploads and previews shapefiles, and displays everything on an interactive map for analysis.",
            Tags = new[] { "GIS", "Shapefiles", "Web Mapping" }
        },
        new SystemProject
        {
            Number = "06", Name = "FIS, Farmers Integrated System",
            Summary = "Two-part system for farmers in the Buganda region: a mobile app for farmers to register their data, and a web portal for admins to manage and allocate resources accordingly.",
            Tags = new[] { "Mobile App", "Web Portal", "Agri-Tech" }
        },
        new SystemProject
        {
            Number = "07", Name = "Ecard System",
            Summary = "SACCO savings-group management system operating across clan, province and parish levels. Members hold an NFC-enabled card showing savings and loans, with tracking for money allocation, grants and disbursement.",
            Tags = new[] { "NFC", "SACCO", "Financial Tracking" }
        },
        new SystemProject
        {
            Number = "08", Name = "E-Commerce System",
            Summary = "Marketplace platform in the spirit of Jiji, built specifically for exhibitors to sell to attendees.",
            Tags = new[] { "Marketplace", "E-Commerce" }
        },
        new SystemProject
        {
            Number = "09", Name = "Etag Feedback",
            Summary = "Post-event feedback system. Attendees respond via QR code or mobile app, with a portal for organizers to analyze the results.",
            Tags = new[] { "QR Code", "Mobile App", "Analytics" }
        },
        new SystemProject
        {
            Number = "10", Name = "SharkPay", Logo = "sharkpay-logo.png",
            Summary = "Bill-payment platform in the spirit of PayWay. Clears URA and utility bills for users and provides bulk payouts.",
            Tags = new[] { "Payments", "Fintech", "Bulk Payouts" },
            Url = "https://sharkpay.co.ug/Home"
        },
        new SystemProject
        {
            Number = "11", Name = "OBUMU",
            Summary = "Pledge and collection platform in the spirit of GoFundMe. Lets users pledge to an event and track savings, with a companion mobile app.",
            Tags = new[] { "ASP.NET Core", "React.js", "Ionic" }
        },
    };

    public List<WebsiteProject> Websites { get; } = new()
    {
        new WebsiteProject { Name = "Armada CRB", Client = "Armada CRB", Url = "https://armadacrb.com/" },
        new WebsiteProject { Name = "YoPas", Client = "YoPas", Url = "https://yopas.co.ug/" },
        new WebsiteProject { Name = "Utrax", Client = "Utrax Agency Ltd", Url = "https://utrax.co.ug/" },
        new WebsiteProject { Name = "SharkPay", Client = "SharkPay Fintech", Url = "https://sharkpay.co.ug/Home" },
        new WebsiteProject { Name = "Ezer Consult", Client = "Ezer Consult", Status = "In progress" },
    };

    public List<Publication> Publications { get; } = new()
    {
        new Publication
        {
            Title = "Co-authored research paper", Type = "IEEE Xplore",
            Url = "https://ieeexplore.ieee.org/abstract/document/10660956"
        },
        new Publication
        {
            Title = "Undergraduate dissertation", Type = "Makerere University Dissertations",
            Url = "https://dissertations.mak.ac.ug/handle/20.500.12281/21246"
        },
    };

    public void OnGet()
    {
    }
}