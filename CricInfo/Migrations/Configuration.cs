namespace CricInfo.Migrations
{
    using CricInfo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CricInfo.Models.CricDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CricInfo.Models.CricDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Articles.AddOrUpdate(
                p => p.Author,
                new Article()
                {
                    Author = "Zlatan Ibrahimovic",
                    Title = @"Ibrahimovic brace takes PSG into fifth League Cup final",
                    Body = @"Zlatan Ibrahimovic struck a last-minute winner to put Paris St Germain in the French League Cup final with a 2-1 win at Nantes on Tuesday having opened the scoring as they boosted their hopes of a maiden domestic double.

The Sweden striker netted after five minutes with a splendid 25-metre strike and sent the Paris club through to the April 19 showpiece match at the Stade de France with a last-gasp header after Olivier Veigneau had equalised in the 81st.",
                    DatePublished = DateTime.Now,

                },
                new Article()
                {
                    Author = "Viswanathan Anand",
                    Title = @"Anand's disappointing time in Zurich Challenge ends with fifth place finish
",
                    Body = @"Five-time world champion Viswanathan Anand continued to struggle with form and had to be content with a fifth-place finish after a poor show in the rapid section of the Zurich Chess Challenge that concluded in Zurich on Tuesday.

Staying joint fourth spot on four points after the Classical games, Anand could manage just one point out of a possible five in the rapid section that has always been his forte and finished with an overall score of just five points out of a possible 10 in the six-player event.",
                    DatePublished = DateTime.Now,

                },
                 new Article()
                {
                    Author = "Brian McDermott",
                    Title = @"McDermott unsure about future as Leeds manager",
                    Body = @"Brian McDermott remains Leeds United manager but admits his future remains unclear after three days of upheaval at the Championship club.

McDermott, appointed in April last year after being sacked by Reading, was reportedly fired on Friday.

The club's owners - GFH Capital - put out a statement on Saturday saying McDermott was still in charge, although he was not in the dugout when Leeds crushed Huddersfield Town 5-1 in front over 31,000 fans, many of whom showed their support for the 52-year-old.

GFH has agreed to sell 75 percent of the club to Eleonora Sport Limited which is owned by the Cellino family who also own Italian Serie A side Cagliari.

McDermott returned to the club's training ground on Monday, but later told a news conference that while he was still in charge, there was no guarantee about his future.

I've no idea if I'm more secure now, he said.

I can't answer that. The most important thing in football is to win games.

When I came in I signed a three-year deal and we talked about a long-term vision with a direction for the football club with stability.

McDermott said it would have been easy to walk away from the club, currently 11th in England's second-tier, but he had no intention of resigning.

Some big people in the game have said don't go back. But how can I not go back? There is no way I would leave the group of staff I have here and the supporters. My job now is to get results. The bigger picture is the stability of this club moving forward and that's what I was put in this position for.

Not too many people have said stick with it. For me, walking away would have been the easy thing to do. I wasn't interested in that, I want to be Leeds United manager

McDermott said he was responsibly for all football matters at the club, and no-one would be allowed into the dugout or dressing room without his permission.

The sale of the club is subject to Football League approval, and McDermott said it was important the ownership situation was resolved as quickly as possible.

Leeds, English champions in 1992, have failed to regain their top-flight status following relegation from the Premier League in 2004.",
                    DatePublished = DateTime.Now,

                },
                 new Article()
                {
                    Author = "Shaun Botterill",
                    Title = @"EPL PHOTOS: Chelsea's win at City throws open title race",
                    Body = @"Branislav Ivanovic's first-half cracker and Jose Mourinho's tactical mastery helped classy Chelsea claim a 1-0 win on Monday at Premier League title rivals Manchester City who failed to score at home for the first time this season.

Chelsea's battling victory put the Londoners level on 53 points with second-placed City and within two points of league leaders Arsenal after 24 games. It also ended City's run of scoring in 61 consecutive home league games since 2010.

Ivanovic struck just after the half-hour mark when Ramires' effort was blocked by Vincent Kompany and fell for the Serbian right back, who let fly first time from the edge of the box and saw his powerful left-foot shot nestle in the far corner.

City had chances to equalise but Chelsea, who also hit the woodwork three times, were always a threat on the break in an absorbing contest, which was decided by Mourinho's ability to find the perfect blend between attack and defence.",
                    DatePublished = DateTime.Now
                },
                                 new Article()
                {
                    DatePublished = DateTime.Now,
                    Author = "David Beckham",
                    Title = @"Beckham to announce franchise decision in Miami",
                    Body = @"A final deal to grant the franchise to Beckham could be several months away though, with a stadium location and financing still required to win approval from the MLS board for his team to become the 22nd club of the top U.S. professional soccer league.

Beckham's announcement will mark the culmination of the start phase, said Irwin Raij, a sports attorney at Foley & Lardner who has worked on numerous stadium deals, but is not involved in Beckham's plans. He's committed and now the real negotiations can begin.

The international soccer star's investment group and MLS Commissioner Don Garber were expected to make the announcement on Wednesday morning at Miami's gleaming new bayfront art museum.

The former Manchester United and Real Madrid star, who also played for the Los Angeles Galaxy In MLS, retired as a player last May and holds $25 million option in his MLS contract to start a new franchise.

Beckham is already in discussions with Miami-Dade Mayor Carlos Gimenez and the county commission to possibly lease county-owned land for a 25,000-seat stadium.

Beckham's investment group has narrowed its stadium search to five possible sites in and around downtown Miami, officials say, including a 25-acre waterfront lot next to the port of Miami's cruise ship terminals, potentially putting the new team at the forefront of Miami's tourism landscape.

The port site is within walking distance of the National Basketball Association's Miami Heat arena and within easy reach of the Miami Beach hotel district.

MLS has stressed the importance of having a final stadium deal, along with a business plan, before it will approve a new team."

                });
        }
    }
}
