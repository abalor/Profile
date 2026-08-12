# Wagisha Emmanuel — Portfolio (ASP.NET Core Razor Pages)

A single-page, dev-focused portfolio built with ASP.NET Core Razor Pages.

## Requirements
- [.NET 8 SDK](https://dotnet.microsoft.com/download) installed on your machine

## Run it
```bash
cd PortfolioSite
dotnet restore
dotnet run
```
Then open the URL shown in the terminal (usually `https://localhost:5001` or `http://localhost:5000`).

## Project structure
```
PortfolioSite/
├── Program.cs                 # App startup
├── PortfolioSite.csproj       # Project file (targets net8.0)
├── Pages/
│   ├── _ViewImports.cshtml
│   ├── _ViewStart.cshtml
│   ├── Index.cshtml           # The single page — hero, about, stack, systems, websites, publications, contact
│   ├── Index.cshtml.cs        # PageModel — all project/website/publication data lives here
│   └── Shared/
│       └── _Layout.cshtml     # Nav, footer, font + stylesheet includes
└── wwwroot/
    ├── css/site.css           # Full design system
    ├── js/site.js             # Scroll-reveal micro-interactions
    └── images/                # Logos + your photo
```

## Editing content
Everything you'd want to update — project descriptions, tags, links, the websites list,
publications — lives as plain C# objects at the top of `Pages/Index.cshtml.cs`. Add a new
project by adding a new `SystemProject { ... }` entry to the `Systems` list; no HTML editing
required.

## Adding a contact email or phone
The Contact section currently only links to GitHub, since that's the only contact info
provided. Add an email/phone line in `Pages/Index.cshtml` under the `#contact` section
whenever you're ready to share one.

## Deploying
Once you're happy with it locally, this runs on any standard ASP.NET Core host — Azure App
Service, a Linux VM with nginx + Kestrel (matches the stack you already use for your other
projects), or a container. `dotnet publish -c Release` produces a deployable build.
