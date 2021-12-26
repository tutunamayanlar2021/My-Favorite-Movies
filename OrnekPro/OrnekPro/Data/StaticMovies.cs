using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrnekPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Data
{
    public static class StaticMovies
    {
        public static void theOriginals(IApplicationBuilder app)
        {

            var scope = app.ApplicationServices.CreateScope();
            var context=scope.ServiceProvider.GetService<MovieContext>();
            context.Database.Migrate();
          if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Movies.Count() == 0) 
                {
                    context.Movies.AddRange(

                        new List<Movie>()
                        {
                                new Movie {
                               
                                Title="Jiu Jitsu",
                                Description="İnception yani Başlangıç, çok sevdiğimiz yönetmen Christopher Nolan’ın, " +
                                "Leonardo DiCaprio, Marion Cotillard, Ellen Page, Cillian Murphy, Ken Watanabe, Michael " +
                                "Caine, Joseph Gordon-Levitt, Tom Hardy gibi izlemeye doyamadığımız bütün oyuncuları bünyesinde barındıran ve seyirciden oldukça iyi notlar almış filmi. Elbette Christopher Nolan filmografisinin çoğunda karşımıza çıkan ve bizi filmin içine çeken Hans Zimmer müziklerini de unutmamak gerekir. Film, insanların rüyalarına girerek onların bilinçaltından bazı sırları çalan veya onların zihinlerine bazı komutlar veren bir ekibi konu alıyor. Oldukça sürükleyici ve ilginç bir senaryosu var. Hala izlememiş olanlara duyurulur. Filmin, 8 Oscar adaylığına rağmen En İyi Sinematografi, Görsel Efekt, Ses Montajı ve Ses Miksajı olmak üzere toplam 4 ödülü bulunuyor.",
                                Director="Dimitri Logothetis",

                                ImageUrl="inc.jpeg",
                                TurId=1
                            },
                            new Movie {
                               
                                Title="Fatman",
                                Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
                                Director="Eshom Nelms",

                                ImageUrl="revelant.jpg",
                                TurId=1
                            },
                            new Movie {
                               
                                Title="The Dalton Gang",
                                Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton join their local sheriff's department. When the...",
                                Director="Christopher Forbes",

                                ImageUrl="k.jpg",
                                TurId=3
                            },
                                new Movie {
                              
                                Title="Tenet",
                                Description="Armed with only one word - Tenet - and fighting for the survival of the entire world, the Protagonist journeys through a twilight world of internat...",
                                Director="Christopher Nolan",

                                ImageUrl="revelant.jpg",
                                TurId=3
                            },
                            new Movie {
                            
                                Title="The Craft: Legacy",
                                Description="Kış Uykusu filmi, alışıldık filmlerden farklı bir anlatıma ve uzunluğa sahiptir. Gerçek hayatın kesitlerini olduğu gibi bizlere yansıtan film, Nuri Bilge Ceylan film tarzını açıkça yansıtır. Yaklaşık 3 saat ve 16 dk. süren Kış Uykusu filmi ve konusu ise; İstanbul’da uzun süre yaşayan ve tiyatroculuk yapan Aydın karakteri, onun kız kardeşi ve genç eşi ile beraber, Kapadokya’da her şeyden izole edilmiş hayatlarını konu alır. Emekli tiyatrocu olan Aydın, genç eşi ve eşinden ayrılan kardeşi Necla ile aslında bambaşka karakterlere sahiptirler.",
                                Director="Zoe Lister-Jones",

                                ImageUrl="1_.jpeg",
                               TurId=3
                            },
                            new Movie {
                                
                                Title="Hard Kill",
                                Description="The work of billionaire tech CEO Donovan Chalmers is so valuable that he hires mercenaries to protect it, and a terrorist group kidnaps his daughte...",
                                Director="Matt Eskandari",

                                ImageUrl="1_.jpeg",
                                TurId=4
                            }
                        }

                   );
                }
                if (context.Turler.Count() == 0)
                {
                    context.Turler.AddRange(
                        new List<Tur>()
                        {
                          new Tur{ Name="Macera"},
                          new Tur{Name="Komedi"},
                          new Tur { Name = "Drama" },
                          new Tur {Name = "Romantik" },

                        }
                        
                    );
               

                }

                context.SaveChanges();   
            }
        }
    }
}
