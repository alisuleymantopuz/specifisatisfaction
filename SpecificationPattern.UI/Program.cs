using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecificationPattern.Domain;
using SpecificationPattern.Specifications;
using SpecificationPattern.Specifications.MobileSpecifications;

namespace SpecificationPattern.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Specs
            //List<Mobile> mobiles = new List<Mobile> {
            //    new Mobile(MobileBrandName.Samsung, MobileType.Smart, 700),   
            //    new Mobile(MobileBrandName.Apple, MobileType.Smart, 800), 
            //    new Mobile(MobileBrandName.Htc, MobileType.Basic), 
            //    new Mobile(MobileBrandName.Samsung, MobileType.Basic) };

            //ISpecification<Mobile> samsungExpSpec = new ExpressionSpecification<Mobile>(o => o.BrandName == MobileBrandName.Samsung);

            //ISpecification<Mobile> htcExpSpec = new ExpressionSpecification<Mobile>(o => o.BrandName == MobileBrandName.Htc);

            //ISpecification<Mobile> samsungAndHtcSpec = samsungExpSpec.And(htcExpSpec);

            //ISpecification<Mobile> samsungHtcExpSpec = samsungExpSpec.Or(htcExpSpec);

            //ISpecification<Mobile> noSamsungExpSpec = new ExpressionSpecification<Mobile>(o => o.BrandName != MobileBrandName.Samsung);

            //ISpecification<Mobile> brandExpSpec = new ExpressionSpecification<Mobile>(o => o.Type == MobileType.Smart);

            //ISpecification<Mobile> premiumSpecification = new MobilePremiumSpecification(600);

            //ISpecification<Mobile> premiumAndSmartSpecification = new MobilePremiumAndSmartSpecification();

            //ISpecification<Mobile> complexSpec = (samsungExpSpec.Or(htcExpSpec)).And(brandExpSpec);

            //ISpecification<Mobile> linqNonLinqExpSpec = noSamsungExpSpec.And(premiumSpecification);

            ////Some fun

            //Console.WriteLine("\n***Samsung mobiles*****\n");
            //var result = mobiles.FindAll(o => samsungExpSpec.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));

            //Console.WriteLine("\n*****Htc mobiles********\n");
            //result = mobiles.FindAll(o => htcExpSpec.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));

            //Console.WriteLine("\n****Htc and samsung mobiles*******\n");
            //result = mobiles.FindAll(o => samsungHtcExpSpec.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));

            //Console.WriteLine("\n****Not samsung*******\n");
            //result = mobiles.FindAll(o => noSamsungExpSpec.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));

            //Console.WriteLine("\n****Htc and samsung mobiles (only smart)*******\n");
            //result = mobiles.FindAll(o => complexSpec.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));

            ////More fun
            //Console.WriteLine("\n****All premium mobile phones*******\n");

            //result = mobiles.FindAll(o => premiumSpecification.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));


            //Console.WriteLine("\n****All premium mobile phones except samsung*******\n");
            //result = mobiles.FindAll(o => linqNonLinqExpSpec.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription()));

            //Console.WriteLine("\n****All premium and smart mobile phones ");
            //result = mobiles.FindAll(o => premiumAndSmartSpecification.IsSatisfiedBy(o));
            //result.ForEach(o => Console.WriteLine(o.GetDescription())); 
            #endregion

            List<Drink> drinks = new List<Drink>()
                {
                    new Drink(DrinkBrandName.Absolut,  DrinkType.Alcohol,100),
                    new Drink(DrinkBrandName.Starbucks,  DrinkType.Coffee,7),
                    new Drink(DrinkBrandName.Tuborg,  DrinkType.Alcohol,10),
                    new Drink(DrinkBrandName.Starbucks,  DrinkType.Coffee,20),
                    new Drink(DrinkBrandName.Absolut,  DrinkType.Alcohol,30)
                };


            ISpecification<Drink> allAlcoholDrinks = new ExpressionSpecification<Drink>(x => x.DrinkType == DrinkType.Alcohol);

            ISpecification<Drink> allCheapDrinks = new ExpressionSpecification<Drink>(x => x.Cost <= 20);

            ISpecification<Drink> tuborgDrinks = new ExpressionSpecification<Drink>(x => x.DrinkBrandName == DrinkBrandName.Tuborg);

            ISpecification<Drink> absolutDrinks = new ExpressionSpecification<Drink>(x => x.DrinkBrandName == DrinkBrandName.Absolut);

            ISpecification<Drink> starbucksDrinks = new ExpressionSpecification<Drink>(x => x.DrinkBrandName == DrinkBrandName.Starbucks);

            ISpecification<Drink> tuborgOrStarbucksDrinks = tuborgDrinks.Or(starbucksDrinks);

            ISpecification<Drink> premiumAndAlcoholDrinks = new DrinkPremiumAndAlcoholSpecification();

            ISpecification<Drink> drinksWithoutTuborg = starbucksDrinks.And(absolutDrinks).Not(tuborgDrinks);

            Console.WriteLine("****************All alcohol drinks");
            var result = drinks.FindAll(allAlcoholDrinks.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));


            Console.WriteLine("****************All cheap drinks");
            result = drinks.FindAll(allCheapDrinks.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));

            Console.WriteLine("****************All tuborg drinks");
            result = drinks.FindAll(tuborgDrinks.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));


            Console.WriteLine("****************All starbucks drinks");
            result = drinks.FindAll(starbucksDrinks.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));

            Console.WriteLine("****************starbucks or tuborg drinks");
            result = drinks.FindAll(tuborgOrStarbucksDrinks.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));

            Console.WriteLine("****************premium and alcohol drinks");
            result = drinks.FindAll(premiumAndAlcoholDrinks.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));

            Console.WriteLine("****************drinks without tuborg");
            result = drinks.FindAll(drinksWithoutTuborg.IsSatisfiedBy);
            result.ForEach(o => Console.WriteLine(o.GetDescription()));

            Console.ReadLine();


        }
    }
}
