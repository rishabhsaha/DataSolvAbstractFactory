using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tg2_Dev_2
{
    class clsFactoryForm
    {
        static public IForm GetField(string fieldType)
        {
            IForm objForm;
            if(fieldType == "Label")
            {
                objForm = new clsFormWithLabel();
            }
            else if(fieldType == "Entry")
            {
                objForm = new clsFormWithEntry();
            }
            else if(fieldType == "Button")
            {
                objForm = new clsFormWithButton();
            }
            else
            {
                return null;
            }
            return objForm;
        }
    }

   
}
