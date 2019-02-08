﻿using System.Collections.Generic;
using MrCMS.Entities.Documents;

namespace MrCMS.Web.Apps.Admin.Infrastructure.Services
{
    public interface IGetDocumentTagsService
    {
        ISet<Tag> GetTags(string tagList);
    }
}