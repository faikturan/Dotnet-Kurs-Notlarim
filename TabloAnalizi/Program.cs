using System;
using System.Collections.Generic;
using System.Linq;

namespace TabloAnalizi
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TestContext context = new TestContext())
            {
                var tabloİsimler = context.Tables.Select(t => t.TableName).ToList();
                var kolonİsimler = context.Colons.Select(c => c.TableName).ToList();

                foreach (var tabloİsim in tabloİsimler)
                {
                    if (kolonİsimler.Contains(tabloİsim))
                    {
                        Ortak oTrue = new Ortak
                        {
                            TableName = tabloİsim,
                            HasSiteId = true
                        };
                        context.Ortaks.Add(oTrue);
                    }
                    else
                    {
                        Ortak oFalse = new Ortak
                        {
                            TableName = tabloİsim,
                            HasSiteId = false
                        };
                        context.Ortaks.Add(oFalse);
                    }
                }

                context.SaveChanges();
            }
        }
    }
}