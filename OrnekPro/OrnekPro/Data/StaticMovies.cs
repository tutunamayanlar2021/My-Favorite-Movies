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
                                MovieId=1,
                                Title="Jiu Jitsu",
                                Description="Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.",
                                Director="Dimitri Logothetis",

                                ImageUrl="1_.jpeg",
                                TurId=1
                            },
                            new Movie {
                                MovieId=2,
                                Title="Fatman",
                                Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
                                Director="Eshom Nelms",

                                ImageUrl="revelant.jpg",
                                TurId=1
                            },
                            new Movie {
                                MovieId=3,
                                Title="The Dalton Gang",
                                Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton join their local sheriff's department. When the...",
                                Director="Christopher Forbes",

                                ImageUrl="k.jpg",
                                TurId=3
                            },
                                new Movie {
                                MovieId=4,
                                Title="Tenet",
                                Description="Armed with only one word - Tenet - and fighting for the survival of the entire world, the Protagonist journeys through a twilight world of internat...",
                                Director="Christopher Nolan",

                                ImageUrl="revelant.jpg",
                                TurId=3
                            },
                            new Movie {
                                MovieId=5,
                                Title="The Craft: Legacy",
                                Description="An eclectic foursome of aspiring teenage witches get more than they bargained for as they lean into their newfound powers.",
                                Director="Zoe Lister-Jones",

                                ImageUrl="1_.jpeg",
                               TurId=3
                            },
                            new Movie {
                                MovieId=6,
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
                          new Tur{TurId=1, Name="Macera"},
                          new Tur{TurId=2,Name="Komedi"},
                          new Tur {TurId=3, Name = "Drama" },
                          new Tur {TurId=4, Name = "Romantik" },

                        }
                        
                    );
               

                }

                context.SaveChanges();   
            }
        }
    }
}
