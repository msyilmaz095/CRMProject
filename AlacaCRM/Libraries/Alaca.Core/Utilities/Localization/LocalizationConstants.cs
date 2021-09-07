﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.Utilities.Localization
{
    public static class LocalizationConstants
    {
        public static readonly LanguageCode[] SupportedLanguages = { 
            new LanguageCode
            {
                Code = "tr-TR",
                DisplayName= "Turkish"
            },
            new LanguageCode
            {
                Code = "en-US",
                DisplayName= "English"
            }, 
            //new LanguageCode
            //{
            //    Code = "fr-FR",
            //    DisplayName = "French"
            //},
            //new LanguageCode
            //{
            //    Code = "km_KH",
            //    DisplayName= "Khmer"
            //},
            //new LanguageCode
            //{
            //    Code = "de-DE",
            //    DisplayName = "German"
            //},
            //new LanguageCode
            //{
            //    Code = "es-ES",
            //    DisplayName = "Español"
            //},
            //new LanguageCode
            //{
            //    Code = "ru-RU",
            //    DisplayName = "Русский"
            //},
            //new LanguageCode
            //{
            //    Code = "sv-SE",
            //    DisplayName = "Swedish"
            //},
            //new LanguageCode
            //{
            //    Code = "id-ID",
            //    DisplayName = "Indonesia"
            //},
            //new LanguageCode
            //{
            //    Code = "it-IT",
            //    DisplayName = "Italian"
            //}
        };
    }
}
