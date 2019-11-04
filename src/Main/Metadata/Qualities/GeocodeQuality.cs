namespace USC.GISResearchLab.Geocoding.Core.Metadata.Qualities
{


    public class GeocodeQuality
    {
        #region Properties

        public GeocodeQualityType Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        #endregion

        public GeocodeQuality(string name, string code, GeocodeQualityType type)
        {
            Name = name;
            Code = code;
            Type = type;
        }




    }


}
