using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tg2_Dev_2
{
    interface IForm
    {
        Xamarin.Forms.View GetFieldObject(string fieldText,string fieldValue);
    }
}
