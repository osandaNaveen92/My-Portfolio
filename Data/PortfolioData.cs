using OsandaPortfolio.Models;

namespace OsandaPortfolio.Data;

public static class PortfolioData
{
    public const string Initials = "H.G";
    public const string FullName = "Osanda Naveen";
    public const string RoleTitle = "Graduate Software Engineer";
    public const string Tagline = "Building AI-powered software and scalable web applications.";
    public const string Location = "Ragama, Sri Lanka";
    public const string StatusLine = "Open to internships";
    public const string Email = "hgosandanaveen@gmail.com";
    public const string Phone = "+94 71 495 0773";
    public const string GitHubUrl = "https://github.com/osandaNaveen92";
    public const string GitHubHandle = "osandaNaveen92";
    public const string LinkedInUrl = "https://www.linkedin.com/in/OsanadNaveen";
    public const string LinkedInHandle = "OsanadNaveen";
    public const string ResumeUrl = "Resume_SE.pdf";
    public const string ProfileImageUrl = "img/profile.jpg";

    public const string ProfileText =
        "I'm a graduate Software Engineer passionate about building intelligent, user-focused " +
        "applications and exploring the latest advancements in software development. I enjoy solving complex problems, " +
        "writing clean and maintainable code, and continuously expanding my knowledge " +
        "across software engineering, cloud technologies, and artificial intelligence. " +
        "I thrive in collaborative environments and aim to create reliable, scalable solutions that deliver real value.";

    public static readonly List<SkillGroup> Skills = new()
    {
        new SkillGroup { Category = "Languages", Items = new() { "C", "C++", "C#", "Java", "Python", "NumPy", "Pandas", "TensorFlow", "R" } },
        new SkillGroup { Category = "Web & APIs", Items = new() { "HTML", "CSS", "JavaScript", "Node.js", "FastAPI", "RestAPI", ".NET" } },
        new SkillGroup { Category = "Data & Cloud", Items = new() { "MySQL", "MongoDB", "AWS", "Power BI" } },
        new SkillGroup { Category = "Tooling", Items = new() { "Git", "GitHub", "VS Code", "Figma", "MATLAB", "AutoCAD" } },
    };

    public static readonly List<string> Interests = new()
    {
        "Data Science", "Software Development", "Generative AI & LLMs", "MLOps", "Cloud Computing"
    };

    public static readonly List<ProjectItem> Projects = new()
    {
        new ProjectItem
        {
            Tag = "Reinforcement Learning · Computer Networks",
            Title = "AI-Driven Dynamic Load Balancing for Mobile Edge Computing",
            DateRange = "Dec 2025 – May 2026",
            StackLine = "Python · Reinforcement Learning · LSTM · Dueling DDQN · NS-3",
            ImageUrl = "img/Edge Computing.jpg",
            ImageAlt = "AI-driven dynamic load balancing project",
            Highlights = new()
            {
                "Built a scheduling framework for MEC environments that cuts processing delay and prevents server overload across heterogeneous edge nodes.",
                "Designed a trend-aware LSTM model that forecasts server load from historical patterns, enabling proactive task scheduling.",
                "Implemented a Dueling Double DQN agent that routes incoming tasks using live load, predicted load, queue depth, and task size.",
            },
            LinkUrl = "https://github.com/osandaNaveen92/AI-Driven-Dynamic-Load-Balancing-Using-Reinforcement-Learning-for-Mobile-Edge-Computing-Environments",
        },
        new ProjectItem
        {
            Tag = "GenAI · Finance · Data Governance",
            Title = "Financial Close GenAI Agent",
            DateRange = "May 2026",
            StackLine = "Python · FastAPI · MongoDB · HTML",
            ImageUrl = "img/finance.jpg",
            ImageAlt = "Financial Close GenAI Agent",
            Highlights = new()
            {
                "Designed a domain-specific multi-agent AI system for financial services with specialized agents for intent detection, compliance validation, knowledge retrieval, and response generation.",
                "Implemented compliance guardrails and safety validation to ensure secure, policy-compliant AI interactions while reducing the risk of unsafe or misleading responses.",
                "Built a modular, scalable architecture with asynchronous processing and a retrieval-ready knowledge base, enabling efficient query handling and future LLM integration.",
            },
            LinkUrl = "https://github.com/osandaNaveen92/Domain-Specialized-AI-Agents-with-Compliance-Guardrails---Financial-Agent",
        },
        new ProjectItem
        {
            Tag = "NLP · Cloud Computing · Security",
            Title = "Data Leakage Prevention in Cloud Environments",
            DateRange = "Aug 2025 – Nov 2025",
            StackLine = "Python · NLP · Machine Learning · AWS",
            ImageUrl = "img/data_leakage.jpg",
            ImageAlt = "Data leakage prevention project",
            Highlights = new()
            {
                "Cleaned and structured large cloud-log datasets to surface patterns and prepare inputs for downstream models.",
                "Trained a DistilBERT classifier for sensitive-data detection and an LSTM autoencoder for behavioral anomaly detection.",
                "Improved detection accuracy and strengthened the system's ability to flag high-risk events.",
            },
            LinkUrl = "https://drive.google.com/drive/folders/1wm2rm1L0teT4fi9t6Ag6jnx0wTyp1Rir?usp=sharing",
        },
        new ProjectItem
        {
            Tag = "Signal Processing · ML",
            Title = "Raw ECG Signals for Patient Risk Stratification",
            DateRange = "Nov 2025",
            StackLine = "React · Node.js · Machine Learning",
            ImageUrl = "img/ecg signal.jpg",
            ImageAlt = "ECG risk stratification project",
            Highlights = new()
            {
                "Built an ML application that analyzes raw digital ECG signals, extracts features, and classifies arrhythmia patterns.",
                "Designed an upload-and-predict interface backed by an ANN trained on the MIT-BIH dataset.",
                "Integrated preprocessing, heartbeat segmentation, and feature engineering into one real-time workflow.",
            },
            LinkUrl = "https://github.com/osandaNaveen92?tab=repositories",
        },
        new ProjectItem
        {
            Tag = "Web Development · Full Stack",
            Title = "EV-Point Electric Vehicle Recharge Bunk Management System",
            DateRange = "Aug 2025",
            StackLine = "JavaScript · CSS · HTML · Firebase",
            ImageUrl = "img/EV.jpg",
            ImageAlt = "EV-Point electric vehicle recharge bunk management system",
            Highlights = new()
            {
                "Developed a full-stack web application for EV charging station discovery, slot reservation, user authentication, and real-time booking management using Firebase.",
                "Designed an admin dashboard for managing charging stations, slot availability, and user bookings while delivering a responsive anduser-friendly interface.",
                "Integrated Google Maps APIs to display charging station locations, enable location-based search, and provide route navigation tonearby EV charging stations.",
            },
            LinkUrl = "https://github.com/osandaNaveen92/EV-Point-Electric-Vehicle-Recharge-Bunk",
        },
    };

    public static readonly List<ExperienceItem> Experience = new()
    {
        new ExperienceItem
        {
            Company = "Unified Mentor Pvt. Ltd.",
            Role = "Full Stack Web Developer Intern",
            DateRange = "May 2025 – Aug 2025",
            Location = "Haryana, India",
            Highlights = new()
            {
                "Built two responsive web apps — a real-time Bus Management System and an EV Recharge Bunk slot-booking platform — both with Firebase integration.",
                "Worked across the full stack: authentication, modular front-end code, database handling, and deployment via GitHub and cloud platforms.",
            },
        },
        new ExperienceItem
        {
            Company = "Encryptix",
            Role = "Data Scientist - Intern",
            DateRange = "May 2025 – Jun 2025",
            Location = "Remote",
            Highlights = new()
            {
                "Completed a 4-week internship, where I gained practical experience in core Data Science concepts. Worked on multiple AI and Machine Learning projects, enhancing my skills in data analysis, model building, and problem-solving.",
            },
        },
        new ExperienceItem
        {
            Company = "OREL IT",
            Role = "Associate Image Processing",
            DateRange = "Dec 2020 – Mar 2021",
            Location = "Kadawatha, Sri Lanka",
            Highlights = new()
            {
                "Worked on image and video processing and annotation tasks for Self Driven vehicale data collection and analysis.",
            },
        },
    };

    public static readonly List<EducationItem> Education = new()
    {
        new EducationItem
        {
            Institution = "National Institute of Technology, Rourkela, India",
            Credential = "B.Tech, Computer Science & Engineering",
            DateRange = "2022 – 2026",
            Detail = "CGPA 6.47 / 10",
            ClassP = "Second Class Upper",
        },
        new EducationItem
        {
            Institution = "Royal College, Colombo 07, Sri Lanka",
            Credential = "G.C.E. Advanced Level — Physics Stream",
            DateRange = "2021",
            Detail = "Physics C · Chemistry B · Combined Maths C",
        },
        new EducationItem
        {
            Institution = "Sri Dharmaloka College, Kelaniya, Sri Lanka",
            Credential = "G.C.E. Ordinary Level",
            DateRange = "2017",
            Detail = "9 A's",
        },
    };

    public static readonly List<MiscItem> Competitions = new()
    {
        new MiscItem { Title = "Economic Times AI Hackathon 2026 — Semi-Finalist", Detail = "Financial Close GenAI Agent" },
        new MiscItem { Title = "GTA MegaJam, NIT Rourkela", Detail = "36-hour game development competition" },
        new MiscItem { Title = "HackNITR 4.0, NIT Rourkela", Detail = "12-hour hackathon" },
    };

    public static readonly List<MiscItem> Certifications = new()
    {
        new MiscItem { Title = "Google Foundations of Data Analytics", DateRange = "December 2024" },
        new MiscItem { Title = "AWS Cloud Essentials", DateRange = "October 2025" },
    };

    public static readonly List<string> CourseWork = new()
    {
        "Data Structures & Algorithms", "Design and Analysis of Algorithms", "Database Management",
        "Object-Oriented Programming", "Software Engineering", "Machine Learning", "Computer Vision",
        "Data Science", "Deep Learning", "Advanced Computer Networks", "Operating Systems",
    };

    public static readonly List<string> Languages = new() { "English (Fluent)", "Sinhala (Native)", "Hindi (Intermediate)" };

    public const string ExtracurricularTitle = "Swimming Club — Vice Captain, NIT Rourkela";
    public const string ExtracurricularDateRange = "2023 – 2026";
    public static readonly List<string> ExtracurricularHighlights = new()
    {
        "Won Two gold medal and one silver medal at the NIT Rourkela Annual Open Swimming Competition (2024, 2025).",
        "Represented NIT Rourkela at the All India Inter-NIT Swimming Competition, 2023–2026.",
    };
}
