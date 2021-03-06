﻿using System;
using System.Threading.Tasks;
using BlueMonkey.MediaServices;

namespace BlueMonkey.ExpenseServices
{
    public interface IFileUploadService
    {
        Task<Uri> UploadMediaFileAsync(IMediaFile mediaFile);
    }
}
