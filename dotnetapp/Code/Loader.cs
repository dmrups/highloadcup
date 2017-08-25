using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;
using dotnetapp.Entities;
using Newtonsoft.Json;

namespace dotnetapp.Code
{
    public class Loader
    {
        IRepository repository;
        Encoding encoder = new UTF8Encoding();

        public Loader(IRepository repository)
        {
            this.repository = repository;
        }

        public void LoadData(string path)
        {
            using (var file = File.OpenRead(path))
            using (var zip = new ZipArchive(file, ZipArchiveMode.Read))
            {
                foreach (var entry in zip.Entries)
                {
                    using (var stream = entry.Open())
                    {
                        var decompressedFile = ReadFile(stream);
                        if (entry.Name.Contains("locations"))
                        {
                            var locations = JsonConvert.DeserializeObject<LocArr>(decompressedFile);
                            repository.AddLocations(locations.locations);
                        }
                        else if (entry.Name.Contains("users"))
                        {
                            var users = JsonConvert.DeserializeObject<UserArr>(decompressedFile);
                            repository.AddUsers(users.users);
                        }
                        else if (entry.Name.Contains("visits"))
                        {
                            var visits = JsonConvert.DeserializeObject<VisitArr>(decompressedFile);
                            repository.AddVisits(visits.visits);
                        }
                    }
                }
            }
        }

        private string ReadFile(Stream stream)
        {
            var str = new StringBuilder();
            int count;
            do
            {
                var buffer = new byte[1024];
                count = stream.Read(buffer, 0, buffer.Length);
                var chunk = encoder.GetString(buffer);
                str.Append(chunk);
            }
            while (count > 0);

            return str.ToString();
        }
    }
}