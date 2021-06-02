using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labshop.Models;

namespace labshop.Models
{
    public class SampleData
    {
        public static void Initialize(ShopContext context)
        {
            context.tovars.AddRange(
                new Tovar
                {
                    TovarName = "Лабораторна робота №2",
                    TovarPrice = "240",
                    NumberOfPur = 0
                },
                new Tovar
                {
                    TovarName = "Лабораторна робота №3",
                    TovarPrice = "200",
                    NumberOfPur = 0
                },
                new Tovar
                {
                    TovarName = "Лабораторна робота №6",
                    TovarPrice = "120",
                    NumberOfPur = 0
                },
                new Tovar
                {
                    TovarName = "Лабораторна робота №7",
                    TovarPrice = "400",
                    NumberOfPur = 0
                },
                new Tovar
                {
                    TovarName = "Лабораторна робота №11",
                    TovarPrice = "350",
                    NumberOfPur = 0
                },
                new Tovar
                {
                     TovarName = "Алгоритми лабораторна №1",
                     TovarPrice = "250",
                     NumberOfPur = 0
                },
                new Tovar
                {
                     TovarName = "Алгоритми лабораторна №2",
                     TovarPrice = "150",
                     NumberOfPur = 0
                },
                new Tovar
                {
                     TovarName = "Алгоритми лабораторна №3",
                     TovarPrice = "500",
                     NumberOfPur = 0
                },
                 new Tovar
                 {
                     TovarName = "Алгоритми лабораторна №4",
                     TovarPrice = "560",
                     NumberOfPur = 0
                 }
                );
            context.downloads.AddRange(
                new Download
                {
                    TovarName = "Лабораторна робота №2",
                    Link = "https://drive.google.com/file/d/1H2ASxpyQft-xzhDlSaMy0QURd2voiESD/view?usp=sharing",
                    DemoLink= "https://drive.google.com/file/d/1WRyRdpwrZ0PTrG6F8a6Cteq-7pIKE8xN/view?usp=sharing",
                },
                 new Download
                 {
                     TovarName = "Лабораторна робота №3",
                     Link = "https://drive.google.com/file/d/1W_fahwYh5FeudKONvQqBrSRNFm5eIXZY/view?usp=sharing",
                     DemoLink = "https://drive.google.com/file/d/1nxUOBEiq4M8LZgam8Ew9dbvIWZdnW42j/view?usp=sharing",
                 },
                  new Download
                  {
                      TovarName = "Лабораторна робота №6",
                      Link = "https://drive.google.com/file/d/1vDauqPxoB0NOLbVg0EqGbrhMGDqbkT2_/view?usp=sharing",
                      DemoLink = "https://drive.google.com/file/d/1l69S07x3YwVlz6iF2_tWNg2SZu-9mnuD/view?usp=sharing",
                  },
                   new Download
                   {
                       TovarName = "Лабораторна робота №7",
                       Link = "https://drive.google.com/file/d/1ndmd0aZr7iwXZd-AoPI7ESOfYnf2gXkw/view?usp=sharing",
                       DemoLink = "https://drive.google.com/file/d/1T6rGzy005ksx4cTq275-NSQN1TDd5IR8/view?usp=sharing",
                   },
                    new Download
                    {
                        TovarName = "Лабораторна робота №11",
                        Link = "https://drive.google.com/file/d/1lzOiHsUxqsWkt9DMWuRAyUO4fALQBkLt/view?usp=sharing",
                        DemoLink = "https://drive.google.com/file/d/1O_E6v5mzWrqqVY8mv-5KIgPs4QKBa0iA/view?usp=sharing",
                    },
                     new Download
                     {
                         TovarName = "Алгоритми лабораторна №1",
                         Link = "https://drive.google.com/file/d/1M1PPF2lmArwXfM5u7c7U01zHZ7OQJ7rO/view?usp=sharing",
                         DemoLink = "https://drive.google.com/file/d/1nnb8_w_en-gP_E593wVlEcE9tQKuYytS/view?usp=sharing",
                     },
                      new Download
                      {
                          TovarName = "Алгоритми лабораторна №2",
                          Link = "https://drive.google.com/file/d/1NCIwF6esafUZ_GxDlwgK21rPZyFZRU3l/view?usp=sharing",
                          DemoLink = "https://drive.google.com/file/d/1j9xPgBmNBi5__Bgq8oWNWwGPEyf3GcH5/view?usp=sharing",
                      },
                       new Download
                       {
                           TovarName = "Алгоритми лабораторна №3",
                           Link = "https://drive.google.com/file/d/1kK9tUyGcGAfpmk8Lkqzhs1ipZuz0SoO8/view?usp=sharing",
                           DemoLink = "https://drive.google.com/file/d/1c0L-aHq8O1ap_TedKdhc-hf_V7P18A-T/view?usp=sharing",
                       },
                        new Download
                        {
                            TovarName = "Алгоритми лабораторна №4",
                            Link = "https://drive.google.com/file/d/1YMxNmnAPvmIHt0gNpG3dMH3G-Qme4Jbg/view?usp=sharing",
                            DemoLink = "https://drive.google.com/file/d/1nphC7wqNsqXbLtfP3gxbF5i8YnUALRwO/view?usp=sharing",
                        }
                ) ;

            //context.SaveChanges();
        }
        
    }
}
