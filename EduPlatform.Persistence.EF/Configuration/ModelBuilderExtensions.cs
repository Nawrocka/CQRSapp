using EduPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF.Configuration
{
    public static class ModelBuilderExtensions
    {
        public static void SeedPost(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Author = "Damian",
                    Date = DateTime.Now.AddMonths(-6),
                    Description = @"Nasze aplikacje ASP.NET CORE coraz częściej są tylko aplikacją REST. To oczywiście wymaga Walidacji po stronie klienta i po stronie serwera
                    Jak taką walidację jak najszybciej zrobić.Może przecież sam napisać takie warunki,
                    ale przy dużej ilości klas,
                    które występują jako parametry mija się to z celem.
                    Możesz też skorzystać z atrybutów i oznaczyć reguły do każdej właściwości.",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Rate = 8,
                    Id = 1,
                    CategoryId = 2,
                    Title = "Walidacja z FluentValidation w ASP.NET Core + Swagger",
                    Url = "https://cezarywalenciuk.pl/blog/programing/walidacja-z-fluentvalidation-waspnet-core--swagger"
                },

                new Post()
                {
                    Author = "Damian",
                    Date = DateTime.Now.AddMonths(-6),
                    Description = @"Programiści codziennie tworzą jakąś aplikację sieciową typu REST. Teraz nastaje pytanie, jak najlepiej zrozumieć jak dane API działa. Do tego mamy dokumentacje, ale jeśli pracujesz w szybkich, zamkniętych projektach to takiej dokumentacji może nie być.",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 2,
                    CategoryId = 2,
                    Rate = 7,
                    Title = "Swagger UI : Dokumentowanie API w ASP.NET CORE",
                    Url = "https://cezarywalenciuk.pl/blog/programing/swagger-ui--dokumentowanie-api-w-aspnet-core"
                },

                new Post()
                {
                    Author = "Stefan",
                    Date = DateTime.Now.AddMonths(-12),
                    Description = @"W pod koniec roku 2017 zacząłem ćwiczyć. Proste ćwiczenia rzeczywiście robią różnice, gdy masz siedzący tryb życia. A co z bieganiem ?
                    Pamiętam jak pierwszy raz na bieżni nie byłem w stanie wytrzymać 5 minut normalnego spaceru. Powoli z tygodnia na dzień zacząłem sobie stawiać wyższe progi i tak odkryłem, że o ile jest to na początku bolesne to jak twoje ciało da Ci te endorfiny to już...aż chce się biegać więcej. ",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 3,
                    CategoryId = 5,
                    Rate = 5,
                    Title = "Bieganie jak się do tego zmotywować : Zdrowie Programisty",
                    Url = "https://cezarywalenciuk.pl/blog/programing/bieganie-jak-sie-do-tego-zmotywowac--zdrowie-programisty"
                },

                new Post()
                {
                    Author = "Damian",
                    Date = DateTime.Now.AddMonths(-12),
                    Description = @"Logowanie działania aplikacji. Jak wiedzieć w końcu, gdy coś nie działa. Mój blog jest napisany w C# i działa po ASP.NET CORE. Jak to jednak bywa z napisaną przez siebie aplikacją pojawiają się błędy więc do bloga dodałem mechanizm logowania błędów. W taki sposób znalazłem wiele dziwnych przypadków uszkodzonych wpisów w formacie XML, które rozwalały Parser. Znalazłem też złe zbudowane przez ze mnie lista kursów. ",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 4,
                    CategoryId = 2,
                    Rate = 5,
                    Title = "NLog z ASP.NET Core : Logowanie błędów w aplikacji",
                    Url = "https://cezarywalenciuk.pl/blog/programing/nlog-z-aspnet-core--logowanie-b%C5%82edow-w-aplikacji"
                },

                new Post()
                {
                    Author = "Damian",
                    Date = DateTime.Now.AddMonths(-12),
                    Description = @"Logowanie działania aplikacji. Jak wiedzieć w końcu, gdy coś nie działa. Mój blog jest napisany w C# i działa po ASP.NET CORE. Jak to jednak bywa z napisaną przez siebie aplikacją pojawiają się błędy więc do bloga dodałem mechanizm logowania błędów. W taki sposób znalazłem wiele dziwnych przypadków uszkodzonych wpisów w formacie XML, które rozwalały Parser. Znalazłem też złe zbudowane przez ze mnie lista kursów. ",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 5,
                    CategoryId = 2,
                    Rate = 5,
                    Title = "NLog z ASP.NET Core : Logowanie błędów w aplikacji",
                    Url = "https://cezarywalenciuk.pl/blog/programing/nlog-z-aspnet-core--logowanie-b%C5%82edow-w-aplikacji"
                },

                new Post()
                {
                    Author = "Damian",
                    Date = DateTime.Now.AddMonths(-8),
                    Description = @"W tym  artykule zobaczymy jak zintegrować AutoMapper  z ASP.NET CORE dla .NET 5, chociaż bądźmy szczerzy możesz skorzystać z tej biblioteki w każdym projekcie w C#.",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 6,
                    CategoryId = 2,
                    Rate = 9,
                    Title = "AutoMapper z ASP.NET CORE czyli mapowanie klas",
                    Url = "https://cezarywalenciuk.pl/blog/programing/automapper-z-aspnet-core"
                },

                new Post()
                {
                    Author = "Adrian",
                    Date = DateTime.Now.AddMonths(-14),
                    Description = @"Nagrywanie Gif - ów ? Robienie obrazków na bloga ? Jak to robić jeszcze szybciej ? ",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 7,
                    CategoryId = 3,
                    Rate = 4,
                    Title = "ShareX : Lepszy PrintScreen oraz robienie Gif-ów twojego pulpitu?",
                    Url = "https://cezarywalenciuk.pl/blog/programing/sharex-lepszy-printscreen-oraz-robienie-gif-ow"
                },

                new Post()
                {
                    Author = "Adrian",
                    Date = DateTime.Now.AddMonths(-15),
                    Description = @"Jak jeszcze lepiej ulepszyć system operacyjny Windows.
                Czy być może programy tobie, które za chwilę to śmieci, które nie będą ci potrzebne?
                Zazwyczaj w tym cyklu pokazuje programy, z które moim bardzo zmieniają przepływ mojej pracy.",
                    ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                    Id = 8,
                    CategoryId = 3,
                    Rate = 5,
                    Title = "QuickLook, TeraCopy, ProcessExplorer czy to potrzebne jest ?",
                    Url = "https://cezarywalenciuk.pl/blog/programing/sharex-lepszy-printscreen-oraz-robienie-gif-ow"
                },

                 new Post()
                 {
                     Author = "Adrian",
                     Date = DateTime.Now.AddMonths(-15),
                     Description = @"Jak jeszcze lepiej ulepszyć system operacyjny Windows.
                Czy być może programy tobie, które za chwilę to śmieci, które nie będą ci potrzebne?
                Zazwyczaj w tym cyklu pokazuje programy, z które moim bardzo zmieniają przepływ mojej pracy.",
                     ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                     Id = 9,
                     CategoryId = 4,
                     Rate = 9,
                     Title = "Docker File dla Go, ASP.NET Core, .NET 5, Java Spring, NodeJS, Python",
                     Url = "https://cezarywalenciuk.pl/blog/programing/docker-file-dla-go-aspnet-core-net-5-java-spring-nodejs-python"
                 }
                );
        }

        public static void SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "CSharp",
                    DisplayName = "C#"
                },

                new Category()
                {
                    Id = 2,
                    Name = "aspnet",
                    DisplayName = "ASP.NET"
                },

                new Category()
                {
                    Id = 3,
                    Name = "triki-z-windows",
                    DisplayName = "Triki z Windows"
                },

                new Category()
                {
                    Id = 4,
                    Name = "docker",
                    DisplayName = "Docker"
                },

                new Category()
                {
                    Id = 5,
                    Name = "filozofia",
                    DisplayName = "Filozofia"
                }
                );
        }

        public static void SeedWebinar(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Webinar>().HasData(
                new Webinar()
                {
                    Title = "Aplikacja C# od Zera Architektura, CQRS, Dobre praktyki",
                    AlreadyHappend = false,
                    Date = DateTime.Now.AddDays(10),
                    Description = @"Ustalenie architektury nie jest prostym zadaniem. Każda decyzja może mieć wielkie komplikacje potem.",
                    FacebookUrl = "https://www.facebook.com/events/407358067213893/",
                    Id = 1,
                    ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/17_apliacjacsharpodzeraarchitekturacqrs.jpg",
                    SlidesUrl = "",
                    WatchFacebookLink = "",
                    WatchYoutubeLink = "",
                },

                new Webinar()
                {
                    Title = "Kubernetes i Docker : Wytłumacz mi i pokaż",
                    AlreadyHappend = false,
                    Date = DateTime.Now.AddDays(-40),
                    Description = @"Kontenery są tutaj. Kubernetes jest de facto platformą do ich uruchamiania i zarządzania.",
                    FacebookUrl = "https://www.facebook.com/events/407358067213893/",
                    Id = 2,
                    ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/17_apliacjacsharpodzeraarchitekturacqrs.jpg",
                    SlidesUrl = "https://panniebieski.github.io/webinar-Kubernetes-Docker-Wytlumacz-mi-i-pokaz/",
                    WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2775230679405348&ref=watch_permalink",
                    WatchYoutubeLink = "https://www.youtube.com/watch?v=7g00wOg9Jto",
                },

                new Webinar()
                {
                    Title = "C# 9, Rekordy i duże zmiany w .NET 5",
                    AlreadyHappend = false,
                    Date = DateTime.Now.AddDays(-60),
                    Description = @"Jak utworzyć projekt w .NET 5?",
                    FacebookUrl = "https://www.facebook.com/events/407358067213893/",
                    Id = 3,
                    ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/15_csharpirekordy.jpg",
                    SlidesUrl = "https://panniebieski.github.io/webinar_CSharp9-Rekordy-i-duze-zamiany-w-net-5/",
                    WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2835303250091399&ref=watch_permalink",
                    WatchYoutubeLink = "https://www.youtube.com/watch?v=ATbLEyd_1Kg",
                },

                 new Webinar()
                 {
                     Title = "Szybki Trening Sql Server 2",
                     AlreadyHappend = false,
                     Date = DateTime.Now.AddDays(-70),
                     Description = @"Czasami jedyne czego potrzebujemy to dobrego przykładu.",
                     FacebookUrl = "https://www.facebook.com/events/407358067213893/",
                     Id = 4,
                     ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/15_csharpirekordy.jpg",
                     SlidesUrl = "https://panniebieski.github.io/webinar_CSharp9-Rekordy-i-duze-zamiany-w-net-5/",
                     WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2835303250091399&ref=watch_permalink",
                     WatchYoutubeLink = "https://www.youtube.com/watch?v=ATbLEyd_1Kg",
                 },

                 new Webinar()
                 {
                     Title = "Pytania rekrutacyjne czyli dalsza kariera",
                     AlreadyHappend = false,
                     Date = DateTime.Now.AddDays(-90),
                     Description = @"Jak wygląda szukanie pracy jako programista w 2020 roku? Czy jest lepiej, czy jest gorzej?",
                     FacebookUrl = "https://www.facebook.com/events/407358067213893/",
                     Id = 5,
                     ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/15_csharpirekordy.jpg",
                     SlidesUrl = "https://panniebieski.github.io/webinar_CSharp9-Rekordy-i-duze-zamiany-w-net-5/",
                     WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2835303250091399&ref=watch_permalink",
                     WatchYoutubeLink = "https://www.youtube.com/watch?v=ATbLEyd_1Kg",
                 }
                );
        }
    }
}
