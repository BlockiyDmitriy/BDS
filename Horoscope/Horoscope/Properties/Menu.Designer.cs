﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Horoscope.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Menu {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Menu() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Horoscope.Properties.Menu", typeof(Menu).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Введите дату предсказания(год, месяц, число):.
        /// </summary>
        internal static string PrintDatePrediction {
            get {
                return ResourceManager.GetString("PrintDatePrediction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ошибка ввода.
        /// </summary>
        internal static string PrintError {
            get {
                return ResourceManager.GetString("PrintError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Прогноз погоды на сегодня, неделю, месяц по дату.
        /// </summary>
        internal static string PrintEx2 {
            get {
                return ResourceManager.GetString("PrintEx2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Вывод статистики по биллинг услугам.
        /// </summary>
        internal static string PrintEx3 {
            get {
                return ResourceManager.GetString("PrintEx3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Введите дату прогноза(неделя, месяц, число).
        /// </summary>
        internal static string PrintForecastData {
            get {
                return ResourceManager.GetString("PrintForecastData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Выход.
        /// </summary>
        internal static string PrintLeave {
            get {
                return ResourceManager.GetString("PrintLeave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Выберите период предсказания:.
        /// </summary>
        internal static string PrintPeriod {
            get {
                return ResourceManager.GetString("PrintPeriod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Предсказание на месяц:.
        /// </summary>
        internal static string PrintPeriodMonth {
            get {
                return ResourceManager.GetString("PrintPeriodMonth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Предсказание на сегодня:.
        /// </summary>
        internal static string PrintPeriodToday {
            get {
                return ResourceManager.GetString("PrintPeriodToday", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Предсказание на неделю:.
        /// </summary>
        internal static string PrintPeriodWeek {
            get {
                return ResourceManager.GetString("PrintPeriodWeek", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Предсказание на год:.
        /// </summary>
        internal static string PrintPeriodYear {
            get {
                return ResourceManager.GetString("PrintPeriodYear", resourceCulture);
            }
        }
    }
}