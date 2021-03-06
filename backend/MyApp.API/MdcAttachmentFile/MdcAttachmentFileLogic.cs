using MyApp.Logic.Entities;
using Reusable.Attachments;
using Reusable.CRUD.Contract;
using Reusable.CRUD.Entities;
using Reusable.CRUD.Implementations.SS;
using Reusable.CRUD.JsonEntities;
using Reusable.EmailServices;
using Reusable.Rest;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Configuration;
using ServiceStack.OrmLite;
using ServiceStack.Text;
using ServiceStack.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Logic
{
    public class MdcAttachmentFileLogic : DocumentLogic<MdcAttachmentFile>, IDocumentLogicAsync<MdcAttachmentFile>
    {
        public override List<MdcAttachmentFile> AdapterOut(params MdcAttachmentFile[] entities)
        {
            foreach (var item in entities)
            {
                item.Attachments = AttachmentsIO.getAttachmentsFromFolder(item.AttachmentsFolder, "MdcAttachment");
            }

            return entities.ToList();
        }
    }
}
