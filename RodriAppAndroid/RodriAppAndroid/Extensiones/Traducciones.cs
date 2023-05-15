using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RodriAppAndroid.Extensiones
{
    [ContentProperty("Text")]
    public class Traducciones:IMarkupExtension
    {
        
        private const string ResourceId = "RodriAppAndroid.Res.AppResources";
        private static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(()=> new ResourceManager(ResourceId,typeof(Traducciones).GetTypeInfo().Assembly));

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
            {
                return string.Empty;
            }
            var ci = Thread.CurrentThread.CurrentCulture;
            var translate = ResMgr.Value.GetString(Text, ci);
            if (translate== null)
            {
                return Text;
            }
            return translate;
        }
    }

}
