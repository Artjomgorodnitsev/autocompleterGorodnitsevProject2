using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace autocompleterGorodnitsevProject.Models
{
    public class NimedDbInitializer:CreateDatabaseIfNotExists<NimedContext>
    {
        protected override void Seed(NimedContext db)
        {
            db.Nimeds.Add(
                new Nimed
                {
                    Id=1,
                    Sugu = "Mees",
                    Emakeelnenimi ="Артём",
                    Voorkeelnenimi="Artjom"
                });
            db.Nimeds.Add(
                new Nimed
                {
                    Id = 2,
                    Sugu="Mees",
                    Emakeelnenimi = "Роман",
                    Voorkeelnenimi = "Roman"
                });

            base.Seed(db);
        }
    }
}