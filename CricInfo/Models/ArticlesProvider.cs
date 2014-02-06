using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class ArticlesProvider
    {
        public List<Article> GetArticles()
        {
            var articles = new List<Article>()
            {
                new Article()
                {
                    Id= 1,
                     Author = "Zlatan Ibrahimovic",
                     Title = @"Ibrahimovic brace takes PSG into fifth League Cup final",
                     Body = @"Zlatan Ibrahimovic struck a last-minute winner to put Paris St Germain in the French League Cup final with a 2-1 win at Nantes on Tuesday having opened the scoring as they boosted their hopes of a maiden domestic double.

The Sweden striker netted after five minutes with a splendid 25-metre strike and sent the Paris club through to the April 19 showpiece match at the Stade de France with a last-gasp header after Olivier Veigneau had equalised in the 81st.",
                                        DatePublished = DateTime.Now,

                },
                new Article()
                {
                    Id= 2,
                     Author = "Viswanathan Anand",
                     Title = @"Anand's disappointing time in Zurich Challenge ends with fifth place finish
",
                     Body = @"Five-time world champion Viswanathan Anand continued to struggle with form and had to be content with a fifth-place finish after a poor show in the rapid section of the Zurich Chess Challenge that concluded in Zurich on Tuesday.

Staying joint fourth spot on four points after the Classical games, Anand could manage just one point out of a possible five in the rapid section that has always been his forte and finished with an overall score of just five points out of a possible 10 in the six-player event.",
                                        DatePublished = DateTime.Now,

                },
                 new Article()
                {
                    Id= 3,
                     Author = "Brian McDermott",
                     Title = @"McDermott unsure about future as Leeds manager",
                     Body = @"Brian McDermott remains Leeds United manager but admits his future remains unclear after three days of upheaval at the Championship club.

McDermott, appointed in April last year after being sacked by Reading, was reportedly fired on Friday.

The club's owners - GFH Capital - put out a statement on Saturday saying McDermott was still in charge, although he was not in the dugout when Leeds crushed Huddersfield Town 5-1 in front over 31,000 fans, many of whom showed their support for the 52-year-old.

GFH has agreed to sell 75 percent of the club to Eleonora Sport Limited which is owned by the Cellino family who also own Italian Serie A side Cagliari.",
                                        DatePublished = DateTime.Now,

                }

            };
            return articles;
        }
    }
}