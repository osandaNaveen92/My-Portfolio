
A Blazor WebAssembly (.NET 8) portfolio site
=======
A personal portfolio site built with **Blazor WebAssembly (.NET 8)**.

## Running it

You'll need the [.NET 8 SDK] installed.

```bash
cd Portfolio
dotnet restore
dotnet run
```

Then open the URL shown in the terminal.

For live-reload while editing:

```bash
dotnet watch
```

## Project structure

```
OsandaPortfolio/
├── Data/
│   └── PortfolioData.cs      ← All your content lives here. Edit this file
│                                to change text, add projects, update links, etc.
├── Models/                   ← Simple C# classes describing a project, skill
│                                group, experience entry, etc.
├── Shared/                   ← One Blazor component per section
│   ├── Nav.razor
│   ├── Hero.razor
│   ├── About.razor
│   ├── Skills.razor
│   ├── Projects.razor
│   ├── Experience.razor
│   ├── Education.razor
│   ├── Extras.razor          ← competitions / certifications / extracurricular
│   ├── Footer.razor
│   └── SignalDivider.razor   ← the waveform divider used between sections
├── Pages/
│   └── Home.razor            ← assembles all sections into the single page
├── Layout/
│   └── MainLayout.razor
└── wwwroot/
    ├── css/app.css           ← all styling (design tokens at the top)
    ├── img/profile.jpg       ← your photo (pulled from your resume PDF)
    └── resume.pdf            ← downloadable resume, replace anytime
```

## Making updates yourself

**Add or edit content (projects, skills, experience, education, etc.):**
Open `Data/PortfolioData.cs` — everything on the page is driven from static
lists in this one file. Add a new `ProjectItem` to the `Projects` list, for
example, and a new card appears automatically.

**Change colors/fonts:**
Open `wwwroot/css/app.css` and edit the `:root` variables at the top
(`--signal` is the teal accent, `--amber` the secondary accent, `--ink`/`--panel`
the background layers).

**Replace your photo:**
Swap out `wwwroot/img/profile.jpg` with a new image of the same filename
(or update `ProfileImageUrl` in `PortfolioData.cs`).

**Update your resume:**
Replace `wwwroot/resume.pdf` with a newer version, same filename.

**Add a new section:**
Create a new `.razor` file in `Shared/`, then drop `<YourSection />` into
`Pages/Home.razor` where you want it to appear.

