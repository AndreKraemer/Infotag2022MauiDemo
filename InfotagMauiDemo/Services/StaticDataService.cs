using InfotagMauiDemo.Models;

namespace InfotagMauiDemo.Services
{
    public class StaticDataService : IDataService
    {

        #region Dummy Data

        private readonly List<Speaker> _speakers = new();
        private readonly List<Session> _sessions = new();

        public StaticDataService()
        {
            _speakers.Add(new Speaker
            {
                Id = 1,
                Name = "Dr. Holger Schwichtenberg",
                Company = "IT-Visions.de | MAXIMAGO",
                TwitterUrl = "https://twitter.com/DOTNETDOKTOR",
                Image = "hs.jpg",
                Bio = "Dr. Holger Schwichtenberg ist einer der bekanntesten Experten für .NET in Deutschland. Zusammen mit rund 50 weiteren Experten unterstützt er im Rahmen der Firma IT-Visions.de mittlere und große Unternehmen durch Beratung und Schulungen beim Erstellen von Software. Zudem ist er Chief Technology Expert bei der Softwareschmiede MAXIMAGO."
            });

            _speakers.Add(new Speaker
            {
                Id = 2,
                Name = "Rainer Stropek",
                Company = "software architects | IT-Visions.at",
                TwitterUrl = "https://twitter.com/rstropek",
                Image = "rs.jpg",
                Bio = "Rainer Stropek ist seit 2008 Mitbegründer und CEO der Firma software architects. Zudem leitet Rainer die österreichische Niederlassung des Beratung- und Schulungsunternehmens IT-Visions. Er ist Experte für .NET- und Webentwicklung, Softwarearchitektur, Datenbanken und Cloud Computing."
            });

            _speakers.Add(new Speaker
            {
                Id = 3,
                Name = "André Krämer",
                Company = "Quality Bytes | IT-Visions.de",
                TwitterUrl = "https://twitter.com/codemurai",
                Image = "ak.jpg",
                Bio = "André Krämer ist Geschäftsführer der Quality Bytes GmbH und Partner im www.IT-Visions.de-Expertennetzwerk. Seine Schwerpunkte als Entwickler, Trainer und Berater liegen in den Bereichen App-Entwicklung mit .NET MAUI, Webentwicklung mit ASP.NET und JavaScript, Azure DevOps, Dokumentengenerierung und Reporting mit TX Text Control sowie der Analyse von Memory Leaks und Performanceproblemen."
            });

            _speakers.Add(new Speaker
            {
                Id = 4,
                Name = "Thomas Claudius Huber",
                Company = "Trivadis",
                TwitterUrl = "https://twitter.com/thomasclaudiush",
                Image = "tch.jpg",
                Bio = "Thomas Claudius Huber ist Microsoft MVP im Bereich Windows Development und Senior Principal Consultant bei der Trivadis AG. Als Trainer, Berater und Entwickler ist er in den Bereichen C#, XAML, TypeScript, und Azure unterwegs. Da ihn Benutzeroberflächen schon seit seinem Informatikstudium faszinierten, setzte er sich seit der ersten WPF-Version mit der UI-Programmierung mit XAML auseinander."
            });

            _sessions.Add(new Session
            {
                Id = 1,
                Title = "Begrüßung",
                Start = new TimeOnly(9, 0),
                End = new TimeOnly(9, 15),
            });

            _sessions.Add(new Session
            {
                Id = 2,
                Title = "Neuerungen in .NET 7.0",
                Description = "Neuerungen in .NET 7.0 für Desktop- und Webentwickler inkl. ASP.NET Core 7.0 und Entity Framework Core 7.0 sowie aktuelle Updates für Visual Studio 2022",
                Start = new TimeOnly(9, 15),
                End = new TimeOnly(11, 0),
                Speaker = _speakers[0]
            });

            _sessions.Add(new Session
            {
                Id = 3,
                Title = "Von C# 10 zu C# 11",
                Description = "Jede neue Version von .NET bringt auch Neuigkeiten in der Sprache C#. In diesem Vortrag sehen wir uns an, was Interessantes für C#-Entwicklerinnen und Entwickler im Paket enthalten ist. Rainer wird die Änderungen und Erweiterungen von C# 10 und C# 11 anhand vieler Codebeispiele zeigen und praktische Tipps und Tricks für den Einsatz in der Praxis weitergeben",
                Start = new TimeOnly(11, 15),
                End = new TimeOnly(12, 30),
                Speaker = _speakers[1]
            });

            _sessions.Add(new Session
            {
                Id = 4,
                Title = "Mittagspause",
                Start = new TimeOnly(12, 30),
                End = new TimeOnly(13, 30),
            });

            _sessions.Add(new Session
            {
                Id = 5,
                Title = "Cross-Platform-Anwendungen mit .NET Multi-Platform App UI (MAUI)",
                Description = ".NET Multi-Platform App UI (.NET MAUI) ist die Evolution von Xamarin.Forms. Die neue Version von Microsofts Cross-Plattform-Framework integriert sich nicht nur tiefer als je zuvor in Visual Studio und das .NET SDK, sie ist auch weitaus einsteigerfreundlicher. In diesem Vortrag erhalten Sie einen praxisorientierten Überblick über.NET MAUI.Anhand praxisnaher Codebeispiele zeigt Ihnen André, wie Sie die ersten Schritte in der Cross - Plattform - Entwicklung gehen können. Abgerundet wird der Vortrag mit einem Überblick über die notwendigen Schritte zur Migration von bestehenden Apps.",
                Start = new TimeOnly(13, 30),
                End = new TimeOnly(14, 45),
                Speaker = _speakers[2]
            });

            _sessions.Add(new Session
            {
                Id = 6,
                Title = "Windows App SDK und die Windows UI Library 3 - der aktuelle Stand für die Windows-App-Entwicklung",
                Description = "Mit WinUI 3 hat Microsoft ein brandneues XAML-basiertes UI-Framework auf den Markt gebracht. Brandneu? Nicht ganz. Die XAML Runtime und XAML Controls der Universal Windows Platform (UWP) wurden von Windows entkoppelt und stehen nun unter dem Namen WinUI 3 als Teil des Windows App SDK zur Verfügung. WinUI 3 stellt ist die native UI - Plattform von Windows 10 und 11.Das bedeutet, dass viele Teile von Windows 10 und 11 mit WinUI 3 entwickelt wurden.Dieses moderne UI Framework können Sie auch für Ihre eigenen Anwendungen einsetzen.",
                Start = new TimeOnly(15, 00),
                End = new TimeOnly(16, 15),
                Speaker = _speakers[3]
            });

            _sessions.Add(new Session
            {
                Id = 7,
                Title = "Neuerungen in der Azure-Cloud für Entwickler",
                Description = "Rainer gibt in seinem Vortrag einen Überblick darüber, welche Neuerungen es in der Azure Cloud gibt.",
                Start = new TimeOnly(12, 15),
                End = new TimeOnly(13, 0),
                Speaker = _speakers[1]
            });

            _sessions.Add(new Session
            {
                Id = 8,
                Title = "Frage- und Antwort-Runde mit allen Vortragenden",
                Description = "Hier können Sie sich gerne auch per Audio/Video melden!",
                Start = new TimeOnly(17, 30),
                End = new TimeOnly(18, 00),
            });

        }

        #endregion

        public IEnumerable<Speaker> GetSpeakers()
        {
            return _speakers;
        }

        public Speaker GetSpeaker(int id)
        {
            return _speakers.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Session> GetSessions()
        {
            return _sessions;
        }

        public Session GetSession(int id)
        {
            return _sessions.FirstOrDefault(s => s.Id == id);
        }

    }
}
