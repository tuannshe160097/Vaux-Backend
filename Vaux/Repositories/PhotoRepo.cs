using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Download;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class PhotoRepo : IPhotoRepo
    {
        private const string PathToServiceAccountKeyFile = @"C:\Users\haiph\source\repos\Vaux-Backend\Vaux\vaux-402415-cc9850aaa031.json";
        private const string DirectoryId = "1ETKk2RRtvOxB_ERo6drE_2jvLrpTqoVW";
        public MemoryStream DriveDownloadFile(string fileId)
        {
            try
            {
                /* Load pre-authorized user credentials from the environment.
                 TODO(developer) - See https://developers.google.com/identity for 
                 guides on implementing OAuth2 for your application. */
                var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
                                .CreateScoped(DriveService.ScopeConstants.Drive);

                // Create Drive API service.
                var service = new DriveService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(fileId);
                var stream = new MemoryStream();

                // Add a handler which will be notified on progress changes.
                // It will notify on each chunk download and when the
                // download is completed or failed.
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };
                request.Download(stream);

                return stream;
            }
            catch (Exception e)
            {
                // TODO(developer) - handle error appropriately
                if (e is AggregateException)
                {
                    Console.WriteLine("Credential Not found");
                }
                else
                {
                    throw;
                }
            }
            return null;
        }

        public async Task<string> DriveUpload(IFormFile formFile, string name)
        {
            try
            {
                long length = formFile.Length;
                if (length < 0)
                    return "Failed";
                using var filestream = formFile.OpenReadStream();
                byte[] bytes = new byte[length];
                filestream.Read(bytes, 0, (int)length);
                MemoryStream image = new MemoryStream(bytes);
                // Load the Service account credentials and define the scope of its access.
                var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
                                .CreateScoped(DriveService.ScopeConstants.Drive);

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                // Upload file Metadata
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = $"{name}.jpg",
                    Parents = new List<string>() { DirectoryId }
                };
                string uploadedFileId;
                await using (var msSource = image)
                {
                    // Create a new file, with metadata and stream.
                    var request = service.Files.Create(fileMetadata, msSource, "image/jpeg");
                    request.Fields = "*";
                    var results = request.Upload();

                    if (results.Status == UploadStatus.Failed)
                    {
                        Console.WriteLine($"Error uploading file: {results.Exception.Message}");
                    }
                    else
                    {
                        Console.WriteLine("Succ");
                    }

                    // the file id of the new file we created
                    uploadedFileId = request.ResponseBody?.Id;
                }

                // Prints the uploaded file id.
                Console.WriteLine("File ID: " + uploadedFileId);
                return uploadedFileId;
            }
            catch (Exception e)
            {
                // TODO(developer) - handle error appropriately
                if (e is AggregateException)
                {
                    Console.WriteLine("Credential Not found");
                }
                else if (e is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
            return null;
        }


/*        public async Task<string> DriveUpdate(MemoryStream image, string name)
        {
            try
            {
                // Load the Service account credentials and define the scope of its access.
                var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
                                .CreateScoped(DriveService.ScopeConstants.Drive);

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                // Upload file Metadata
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = $"{name}.jpg",
                    Parents = new List<string>() { DirectoryId }
                };
                string uploadedFileId;
                await using (var msSource = image)
                {
                    // Create a new file, with metadata and stream.
                    var request = service.Files.Update(fileMetadata, msSource, "image/jpeg");
                    request.Fields = "*";
                    var results = request.Upload();

                    if (results.Status == UploadStatus.Failed)
                    {
                        Console.WriteLine($"Error uploading file: {results.Exception.Message}");
                    }
                    else
                    {
                        Console.WriteLine("Succ");
                    }

                    // the file id of the new file we created
                    uploadedFileId = request.ResponseBody?.Id;
                }

                // Prints the uploaded file id.
                Console.WriteLine("File ID: " + uploadedFileId);
                return uploadedFileId;
            }
            catch (Exception e)
            {
                // TODO(developer) - handle error appropriately
                if (e is AggregateException)
                {
                    Console.WriteLine("Credential Not found");
                }
                else if (e is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
            return null;
        }*/
    }
}
