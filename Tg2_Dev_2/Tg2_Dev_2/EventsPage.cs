using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace Tg2_Dev_2
{
    public class EventsPage : ContentPage
    {
        public EventsPage(string schema)
        {
            var layout = new StackLayout();
            
            TGSchema obj = JsonConvert.DeserializeObject<TGSchema>(schema);
            List<View> lstObjects = new List<View>();
            View createField;
            foreach (Field field in obj.Fields)
            {
                createField = clsFactoryForm.GetField(field.FieldType).GetFieldObject(field.FieldName,field.FieldValue);
                lstObjects.Add(createField);
            }
           

            

            foreach (var o in lstObjects)
            {
                layout.Children.Add(o);
            }
            
            Content = layout;
        }
    }
}
