using AutoMapper;

namespace ReadWriteFile.Models
{//AutoMapper
    public class Mapper_YourNewStyleDB
    {

       public IMapper mapper { get; set; }

        public Mapper_YourNewStyleDB()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<YourNewStyle, YourNewStyleDB>()
            .ForMember<int>(
               x => x.id, con => con.ResolveUsing(ConverterID)

                )
            .ForMember<double>
                (
                y => y.price_brutto, con => con.ResolveUsing(ConverterPriceBrutto)

                )
                .ForMember<double>
                (
                y => y.price_netto, con => con.ResolveUsing(ConverterPriceNetto)

                )
                .ForMember<string>
                (
                y => y.owner, con => con.MapFrom(x => x.Producer)
                )
                .ForMember<string>
                (
                 y => y.producer_code, o => o.MapFrom(x => x.Producer_Code != null ? x.Producer : "None")
                )
                .ForMember<string>
                (
                  y => y.code, o => o.MapFrom(x => x.Code != null ? x.Code : "None")
                )
                );
            mapper = config.CreateMapper();
        }

        public YourNewStyleDB MapMet(YourNewStyle obj1)
        {          
                       
            var empDTO = mapper.Map<YourNewStyleDB>(obj1);
            return empDTO != null ? empDTO : new YourNewStyleDB();
        }

        private object ConverterID(YourNewStyle arg)
        {
            int x = 0;
            int.TryParse(arg.Id,out x);
            return x; 
           
        }
        private object ConverterPriceBrutto(YourNewStyle arg)
        {
            string y = arg.Price_brutto.Replace('.', ',');
            double x = 0;
            double.TryParse(y, out x);
            return x;

        }
        private object ConverterPriceNetto(YourNewStyle arg)
        {
            string y = arg.Price_netto.Replace('.', ',');
            double x = 0;
            double.TryParse(y, out x);
            return x;

        }
    }



}
