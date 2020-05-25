using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDelegate_CommunicatedBetwenTwoForm.Modle;
namespace DemoDelegate_CommunicatedBetwenTwoForm.Idao
{
    interface IDaoFrmA
    {
       List<FormContent> getAllMessageFrmA();

        FormContent addMessage(FormContent message);
    }
}
