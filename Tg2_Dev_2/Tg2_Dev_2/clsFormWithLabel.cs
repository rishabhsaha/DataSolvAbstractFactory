using Xamarin.Forms;
namespace Tg2_Dev_2
{
    internal class clsFormWithLabel : IForm
    {
        public Xamarin.Forms.View GetFieldObject(string fieldText, string fieldValue)
        {
            return new Label
            {
                StyleId = fieldText,
                Text = fieldValue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
        }
    }
}