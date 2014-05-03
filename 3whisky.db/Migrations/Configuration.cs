using System;
using System.Data.Entity.Migrations;

using Whisky.Db.Entities;

namespace Whisky.Db.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(Context context)
        {
            context.Products.AddOrUpdate(p => p.Id, new Product()
            {
                Id = 1,
                Name = "Glenfiddich 18 y.o",
                ShortDescription = "Aroma: lehké a delikátní, štavnatý košík ovoce, hrušky, trešne, švestky, med.",
                LongDescription = @"<img class=""pull-left img-rounded img-responsive"" src=""https://www.forwhiskeylovers.com/sites/default/files/styles/uc_product_full/public/store/balvenie-21-year-old-portwood-speyside-single-malt-750mlfile_14_61.jpg"">
<h2>Balvenie 21 y.o Portwood</h2>
0,7l, 40%, single malt
<h3>Hodnocení whisky podle M. Jacksona (Whisky Magazin):</h3>
<p>
<b>Aroma:</b><br />
Parfémové a ovocné, mucenkové plody, rozinky, orechová suchost, marcipán.
<br /><b>Chut:</b><br />
Velmi komplexní, karamelová, smetanová, vínová, anýzová. Dokoncení: Dlouhé, cedrové, suché.</p>

<h3>Hodnocení whisky podle J. Murraye (Whisky Magazin):</h3>
<p>
<br /><b>Aroma:</b><br />
Ovocné a zralé, príjemne hroznové a zároven kourové.
<br /><b>Chut:</b><br /> Hedvábnejší než jiné Balvenie, s více ovocem a korením, ale trochu postrádá komplexnost.
<br /><b>Dokoncení:</b><br /> Obrovské. Vlna za vlnou hlubokých kourove dubových tónu, ke konci jemný náznak mízy a smerem k bourbonu.</p>",
                Price = 1642.00m,
                Created = DateTime.Parse("2014-04-27 18:50:51.910"),
                Enabled = true,
                ImageUrl = "http://cdn4.masterofmalt.com/whiskies/p-1987/glenfiddich-18-year-old-whisky.jpg",
                Active = true,
            }, new Product()
            {
                Id = 2,
                Name = "Dalwhinnie Distillers Edition",
                ShortDescription = "Aroma: oloroso, lékorice, po korenech, trávová.",
                LongDescription = @"<img class=""pull-left img-rounded img-responsive"" src=""https://www.forwhiskeylovers.com/sites/default/files/styles/uc_product_full/public/store/balvenie-21-year-old-portwood-speyside-single-malt-750mlfile_14_61.jpg"">
<h2>Balvenie 21 y.o Portwood</h2>
0,7l, 40%, single malt
<h3>Hodnocení whisky podle M. Jacksona (Whisky Magazin):</h3>
<p>
<b>Aroma:</b><br />
Parfémové a ovocné, mucenkové plody, rozinky, orechová suchost, marcipán.
<br /><b>Chut:</b><br />
Velmi komplexní, karamelová, smetanová, vínová, anýzová. Dokoncení: Dlouhé, cedrové, suché.</p>

<h3>Hodnocení whisky podle J. Murraye (Whisky Magazin):</h3>
<p>
<br /><b>Aroma:</b><br />
Ovocné a zralé, príjemne hroznové a zároven kourové.
<br /><b>Chut:</b><br /> Hedvábnejší než jiné Balvenie, s více ovocem a korením, ale trochu postrádá komplexnost.
<br /><b>Dokoncení:</b><br /> Obrovské. Vlna za vlnou hlubokých kourove dubových tónu, ke konci jemný náznak mízy a smerem k bourbonu.</p>",
                Price = 1983.00m,
                Created = DateTime.Parse("2014-04-27 18:50:51.910"),
                Enabled = true,
                ImageUrl = "http://www.drinksupermarket.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/d/a/dalwhinnie_distillers_edition_1992_highland_single_malt_scotch_whisky_70cl.jpg",
                Active = true,
            }, new Product()
            {
                Id = 2,
                Name = "Balvenie 21 y.o Portwood",
                ShortDescription = "Aroma: Parfémové a ovocné, mucenkové plody, rozinky, orechová suchost, marcipán.",
                LongDescription = @"<img class=""pull-left img-rounded img-responsive"" src=""https://www.forwhiskeylovers.com/sites/default/files/styles/uc_product_full/public/store/balvenie-21-year-old-portwood-speyside-single-malt-750mlfile_14_61.jpg"">
<h2>Balvenie 21 y.o Portwood</h2>
0,7l, 40%, single malt
<h3>Hodnocení whisky podle M. Jacksona (Whisky Magazin):</h3>
<p>
<b>Aroma:</b><br />
Parfémové a ovocné, mucenkové plody, rozinky, orechová suchost, marcipán.
<br /><b>Chut:</b><br />
Velmi komplexní, karamelová, smetanová, vínová, anýzová. Dokoncení: Dlouhé, cedrové, suché.</p>

<h3>Hodnocení whisky podle J. Murraye (Whisky Magazin):</h3>
<p>
<br /><b>Aroma:</b><br />
Ovocné a zralé, príjemne hroznové a zároven kourové.
<br /><b>Chut:</b><br /> Hedvábnejší než jiné Balvenie, s více ovocem a korením, ale trochu postrádá komplexnost.
<br /><b>Dokoncení:</b><br /> Obrovské. Vlna za vlnou hlubokých kourove dubových tónu, ke konci jemný náznak mízy a smerem k bourbonu.</p>",
                Price = 3201.00m,
                Created = DateTime.Parse("2014-04-27 18:50:51.910"),
                Enabled = true,
                ImageUrl = "https://www.forwhiskeylovers.com/sites/default/files/styles/uc_product_full/public/store/balvenie-21-year-old-portwood-speyside-single-malt-750mlfile_14_61.jpg",
                Active = true,
            });
        }
    }
}