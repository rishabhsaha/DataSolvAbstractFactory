using System;
using Xamarin.Forms;

namespace Tg2_Dev_2
{
    internal class clsFormWithButton : IForm
    {
        public View GetFieldObject(string fieldText, string fieldValue)
        {
            var btn_Sumit = new Button
            {
                StyleId = fieldText,
                Text = fieldValue
            };
            btn_Sumit.Clicked += delegate {
                //Do the login task here
            };
            return btn_Sumit;
        }
    }
}