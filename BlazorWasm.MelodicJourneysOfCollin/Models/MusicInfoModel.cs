﻿using Newtonsoft.Json;

namespace BlazorWasm.MelodicJourneysOfCollin.Models
{
    public class MusicInfoModel
    {
        public int Id { get; set; }
        public string? Artists { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public string? Link { get; set; }
        public string? Cover { get; set; }
        public int PlatformType { get; set; }
        public string? Length { get; set; }
        public List<DownloadLinkModel> DownloadLinks { get; set; }
    }
    
    public class DownloadLinkModel
    {
        public string PlatformType { get; set; }
        public string DownloadLink { get; set; }
    }
}
