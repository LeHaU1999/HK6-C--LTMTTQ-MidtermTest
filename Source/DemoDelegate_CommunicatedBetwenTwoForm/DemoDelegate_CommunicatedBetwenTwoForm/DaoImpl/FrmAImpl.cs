using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDelegate_CommunicatedBetwenTwoForm.Idao;
using DemoDelegate_CommunicatedBetwenTwoForm.Modle;

namespace DemoDelegate_CommunicatedBetwenTwoForm.DaoImpl
{
    class FrmAImpl:IDaoFrmA
    {
        LinQSendMessageDataContext db;
        List<FormContent> listContent;

        public FrmAImpl()
        {
            db = new LinQSendMessageDataContext();
            using (db)
            {
                var content = from x in db.FormContents select x;
                db.DeferredLoadingEnabled = true;
                listContent = content.ToList();
            }
        }

        public FormContent addMessage(FormContent message)
        {
            db = new LinQSendMessageDataContext();
            FormContent content = new FormContent();
            content = message;
            db.FormContents.InsertOnSubmit(content);
            db.SubmitChanges();
            return content;
        }

        public List<FormContent> getAllMessageFrmA()
        {
            db = new LinQSendMessageDataContext();
            var content = from x in db.FormContents select x;
            listContent = content.ToList();
            return listContent;
        }
    }
}
