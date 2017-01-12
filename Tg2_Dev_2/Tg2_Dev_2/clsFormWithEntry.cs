using System;
using Xamarin.Forms;

namespace Tg2_Dev_2
{
    internal class clsFormWithEntry : IForm
    {
        public View GetFieldObject(string fieldText, string fieldValue)
        {
            return new Entry
            {
                StyleId = fieldText,
                Text = fieldValue
            };
        }
    }
}