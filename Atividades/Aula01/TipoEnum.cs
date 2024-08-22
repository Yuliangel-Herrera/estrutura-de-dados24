using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class TipoEnum
    {
        public enum Language
        {
            PTBR, EN, RU
        }
        public TipoEnum(){
    
        }

        public Language _language = Language.PTBR;
        public Language GetLanguageEnum(string lang)
        {
            switch (lang.ToLower())
            {
                case "português" :
                return Language.PTBR;
                case "inglês" :
                return Language.EN;
                case "russo" :
                return Language.RU;
                default :
                return Language.PTBR;

            }
        }
    }

}