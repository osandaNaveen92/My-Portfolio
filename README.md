<<<<<<< HEAD
# My-Portfolio
A Blazor WebAssembly (.NET 8) portfolio site
=======
# Osanda Naveen — Portfolio

A personal portfolio site built with **Blazor WebAssembly (.NET 8)**.

## Running it

You'll need the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed.

```bash
cd OsandaPortfolio
dotnet restore
dotnet run
```

Then open the URL shown in the terminal (usually `https://localhost:5001` or similar).

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

## Deploying

Since this is a standalone Blazor WebAssembly app, you can host it for free
as a static site:

```bash
dotnet publish -c Release -o publish
```

The output in `publish/wwwroot` can be deployed to **GitHub Pages**,
**Netlify**, **Vercel**, **Azure Static Web Apps**, or any static host.

## Design notes

- Dark, technical theme (`#0B1220` base) with a teal "signal" accent — a nod
  to the ECG/signal-processing and telemetry-style systems work in your projects.
- Section labels use a `// 01 LABEL` comment style and IBM Plex Mono, echoing
  a code/dashboard aesthetic.
- The waveform in the hero and the thin divider between sections are the same
  motif reused throughout, so it reads as intentional rather than decorative.
>>>>>>> 5dd3185 (chore: initialize Blazor WebAssembly portfolio)
