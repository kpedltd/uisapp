﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UisApp.API.Resources {
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
    internal class UriResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UriResource() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UisApp.API.Resources.UriResource", typeof(UriResource).Assembly);
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
        ///   Ищет локализованную строку, похожую на /lecturer/login.
        /// </summary>
        internal static string auth {
            get {
                return ResourceManager.GetString("auth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /schedule/concrete.
        /// </summary>
        internal static string concrete_schedule {
            get {
                return ResourceManager.GetString("concrete_schedule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /attendance/create_entries.
        /// </summary>
        internal static string create_attendance_entries {
            get {
                return ResourceManager.GetString("create_attendance_entries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /lecturer/getme.
        /// </summary>
        internal static string getme {
            get {
                return ResourceManager.GetString("getme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /schedule/lecturer.
        /// </summary>
        internal static string lecturer_schedule {
            get {
                return ResourceManager.GetString("lecturer_schedule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /lecturer/subjects.
        /// </summary>
        internal static string lecturer_subjects {
            get {
                return ResourceManager.GetString("lecturer_subjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /lecturer/logout.
        /// </summary>
        internal static string logout {
            get {
                return ResourceManager.GetString("logout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /attendance/students.
        /// </summary>
        internal static string student_attendance {
            get {
                return ResourceManager.GetString("student_attendance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /attendance/change_state.
        /// </summary>
        internal static string student_check {
            get {
                return ResourceManager.GetString("student_check", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /subject/groups.
        /// </summary>
        internal static string subject_groups {
            get {
                return ResourceManager.GetString("subject_groups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на /lecturer/update_photo.
        /// </summary>
        internal static string update_photo {
            get {
                return ResourceManager.GetString("update_photo", resourceCulture);
            }
        }
    }
}
