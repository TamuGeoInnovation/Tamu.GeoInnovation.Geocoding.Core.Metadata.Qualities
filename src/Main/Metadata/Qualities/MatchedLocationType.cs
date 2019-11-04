namespace USC.GISResearchLab.Geocoding.Core.Metadata.Qualities
{


    public class MatchedLocationType
    {
        #region Properties


        public MatchedLocationTypes Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        #endregion

        public MatchedLocationType()
        {
            Type = MatchedLocationTypes.Unknown;
        }

        public MatchedLocationType(string name, string code, MatchedLocationTypes type)
        {
            Name = name;
            Code = code;
            Type = type;
        }

    }
}
