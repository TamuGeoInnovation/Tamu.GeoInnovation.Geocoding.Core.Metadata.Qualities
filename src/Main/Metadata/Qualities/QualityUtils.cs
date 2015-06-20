using System;

using USC.GISResearchLab.Geocoding.Core.Metadata.Qualities;
using System.Data;

namespace USC.GISResearchLab.Geocoding.Core.Utils.Qualities
{
	/// <summary>
	/// Summary description for QualityUtils.
	/// </summary>
	public class QualityUtils
	{

        //public const int QUALITY_GPS = 0;
        //public const int QUALITY_EXACT_PARCEL_CENTROID = 1;
        //public const int QUALITY_NEAREST_PARCEL_CENTROID = 2;
        //public const int QUALITY_ACTUAL_LOT_INTERPOLATION = 3;
        //public const int QUALITY_UNIFORM_LOT_INTERPOLATION = 4;
        //public const int QUALITY_ADDRESS_RANGE_INTERPOLATION = 5;
        //public const int QUALITY_STREET_INTERSECTION = 6;
        //public const int QUALITY_STREET_CENTROID = 7;
        //public const int QUALITY_ZIP_CODE_PLUS_5_TABULATION_AREA_CENTROID = 8;
        //public const int QUALITY_ZIP_CODE_PLUS_4_TABULATION_AREA_CENTROID = 9;
        //public const int QUALITY_ZIP_CODE_PLUS_2_TABULATION_AREA_CENTROID = 10;
        //public const int QUALITY_ZIP_CODE_TABULATION_AREA_CENTROID = 11;
        //public const int QUALITY_CITY_CENTROID = 12;
        //public const int QUALITY_COUNTY_SUBDIVISION_CENTROID = 13;
        //public const int QUALITY_COUNTY_CENTROID = 14;
        //public const int QUALITY_STATE_CENTROID = 15;
        //public const int QUALITY_COUNTRY_CENTROID = 16;
        //public const int QUALITY_UNMATCHABLE = 99;
        //public const int QUALITY_UNKNOWN = -1;

		public const string QUALITY_NAME_GPS = "QUALITY_GPS";
		public const string QUALITY_NAME_EXACT_PARCEL_CENTROID = "QUALITY_EXACT_PARCEL_CENTROID";
		public const string QUALITY_NAME_NEAREST_PARCEL_CENTROID = "QUALITY_NEAREST_PARCEL_CENTROID";
		public const string QUALITY_NAME_ACTUAL_LOT_INTERPOLATION = "QUALITY_ACTUAL_LOT_INTERPOLATION";
		public const string QUALITY_NAME_UNIFORM_LOT_INTERPOLATION = "QUALITY_UNIFORM_LOT_INTERPOLATION";
		public const string QUALITY_NAME_ADDRESS_RANGE_INTERPOLATION = "QUALITY_ADDRESS_RANGE_INTERPOLATION";
        public const string QUALITY_NAME_BUILDING_CENTROID = "QUALITY_BUILDING_CENTROID";
        public const string QUALITY_NAME_BUILDING_FRONT_DOOR = "QUALITY_BUILDING_FRONT_DOOR";
		public const string QUALITY_NAME_STREET_INTERSECTION = "QUALITY_STREET_INTERSECTION";
		public const string QUALITY_NAME_STREET_CENTROID = "QUALITY_STREET_CENTROID";
        public const string QUALITY_NAME_DYNAMIC_FEATURE_COMPOSITION_CENTROID = "QUALITY_DYNAMIC_FEATURE_COMPOSITION_CENTROID";


        public const string QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID = "QUALITY_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID";
        public const string QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID = "QUALITY_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID";
        public const string QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID = "QUALITY_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID";
        public const string QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID = "QUALITY_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID";
        public const string QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID = "QUALITY_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID";
        public const string QUALITY_NAME_ZIP_CODE_TABULATION_AREA_CENTROID = "QUALITY_ZIP_CODE_TABULATION_AREA_CENTROID";

        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID";
        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID";

        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID";
        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID";
        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID";
        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID";
        public const string QUALITY_NAME_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID = "QUALITY_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID";
        public const string QUALITY_NAME_USPS_ZIP_CODE_AREA_CENTROID = "QUALITY_USPS_ZIP_CODE_AREA_CENTROID";

        public const string QUALITY_NAME_CITY_CENTROID = "QUALITY_CITY_CENTROID";
        public const string QUALITY_NAME_CONSOLIDATED_CITY_CENTROID = "QUALITY_CONSOLIDATED_CITY_CENTROID";
		public const string QUALITY_NAME_COUNTY_SUBDIVISION_CENTROID = "QUALITY_COUNTY_SUBDIVISION_CENTROID";
		public const string QUALITY_NAME_COUNTY_CENTROID = "QUALITY_COUNTY_CENTROID";
		public const string QUALITY_NAME_STATE_CENTROID = "QUALITY_STATE_CENTROID";
		public const string QUALITY_NAME_COUNTRY_CENTROID = "QUALITY_COUNTRY_CENTROID";
		public const string QUALITY_NAME_UNMATCHABLE = "QUALITY_UNMATCHABLE";
		public const string QUALITY_NAME_UNKNOWN = "QUALITY_UNKNOWN";

        public const string QUALITY_SHORT_NAME_GPS = "gps";
        public const string QUALITY_SHORT_NAME_EXACT_PARCEL_CENTROID = "exact parcel";
        public const string QUALITY_SHORT_NAME_NEAREST_PARCEL_CENTROID = "nearest parcel";
        public const string QUALITY_SHORT_NAME_ACTUAL_LOT_INTERPOLATION = "actual lot";
        public const string QUALITY_SHORT_NAME_UNIFORM_LOT_INTERPOLATION = "uniform lot";
        public const string QUALITY_SHORT_NAME_ADDRESS_RANGE_INTERPOLATION = "address rng";
        public const string QUALITY_SHORT_NAME_BUILDING_CENTROID = "building centrd";
        public const string QUALITY_SHORT_NAME_BUILDING_FRONT_DOOR = "building door";
        public const string QUALITY_SHORT_NAME_STREET_INTERSECTION = "street inter";
        public const string QUALITY_SHORT_NAME_STREET_CENTROID = "street centrd";
        public const string QUALITY_SHORT_NAME_DYNAMIC_FEATURE_COMPOSITION_CENTROID = "dyn comp centrd";

        public const string QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID = "ZCTA+5";
        public const string QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID = "ZCTA+4";
        public const string QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID = "ZCTA+3";
        public const string QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID = "ZCTA+2";
        public const string QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID = "ZCTA+1";
        public const string QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_CENTROID = "ZCTA";

        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID = "USPS Zip+5 line";
        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID = "USPS Zip+4 line";

        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID = "USPS Zip+5 area";
        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID = "USPS Zip+4 area";
        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID = "USPS Zip+2 area";
        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID = "USPS Zip+2 area";
        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID = "USPS Zip+1 area";
        public const string QUALITY_SHORT_NAME_USPS_ZIP_CODE_AREA_CENTROID = "USPS Zip area";

        public const string QUALITY_SHORT_NAME_CITY_CENTROID = "city";
        public const string QUALITY_SHORT_NAME_CONSOLIDATED_CITY_CENTROID = "consolidated city";
        public const string QUALITY_SHORT_NAME_COUNTY_SUBDIVISION_CENTROID = "county sub";
        public const string QUALITY_SHORT_NAME_COUNTY_CENTROID = "county";
        public const string QUALITY_SHORT_NAME_STATE_CENTROID = "state";
        public const string QUALITY_SHORT_NAME_COUNTRY_CENTROID = "country";
        public const string QUALITY_SHORT_NAME_UNMATCHABLE = "unmatchable";
        public const string QUALITY_SHORT_NAME_UNKNOWN = "unknown";

		public const string QUALITY_DESCRIPTION_GPS = "GPS";
		public const string QUALITY_DESCRIPTION_EXACT_PARCEL_CENTROID = "Exact parcel centroid";
		public const string QUALITY_DESCRIPTION_NEAREST_PARCEL_CENTROID = "Nearest parcel centroid";
		public const string QUALITY_DESCRIPTION_ACTUAL_LOT_INTERPOLATION = "Actual lot linear interpolation";
		public const string QUALITY_DESCRIPTION_UNIFORM_LOT_INTERPOLATION = "Uniform lot linear interpolation";
		public const string QUALITY_DESCRIPTION_ADDRESS_RANGE_INTERPOLATION = "Addres range interpolation";
        public const string QUALITY_DESCRIPTION_BUILDING_CENTROID = "Building centroid";
        public const string QUALITY_DESCRIPTION_BUILDING_FRONT_DOOR = "Building front door";
		public const string QUALITY_DESCRIPTION_STREET_INTERSECTION = "Street intersection";
		public const string QUALITY_DESCRIPTION_STREET_CENTROID = "Street centroid";
        public const string QUALITY_DESCRIPTION_DYNAMIC_FEATURE_COMPOSITION_CENTROID = "Dynamic feature composition centroid";

        public const string QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID = "ZCTA+5 centroid";
        public const string QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID = "ZCTA+4 centroid";
        public const string QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID = "ZCTA+4 centroid";
        public const string QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID = "ZCTA+2 centroid";
        public const string QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID = "ZCTA+1 centroid";
        public const string QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_CENTROID = "ZCTA centroid";

        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID = "USPS Zip+5 line centroid";
        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID = "USPS Zip+4 line centroid";

        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID = "USPS Zip+5 area centroid";
        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID = "USPS Zip+4 area centroid";
        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID = "USPS Zip+3 area centroid";
        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID = "USPS Zip+2 area centroid";
        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID = "USPS Zip+1 area centroid";
        public const string QUALITY_DESCRIPTION_USPS_ZIP_CODE_AREA_CENTROID = "USPS Zip area centroid";

        public const string QUALITY_DESCRIPTION_CITY_CENTROID = "City centroid";
        public const string QUALITY_DESCRIPTION_CONSOLIDATED_CITY_CENTROID = "Consolidated city centroid";
        public const string QUALITY_DESCRIPTION_COUNTY_SUBDIVISION_CENTROID = "County subdivision centroid";
		public const string QUALITY_DESCRIPTION_COUNTY_CENTROID = "County centroid";
        public const string QUALITY_DESCRIPTION_STATE_CENTROID = "State centroid";
		public const string QUALITY_DESCRIPTION_COUNTRY_CENTROID = "Country centroid";
		public const string QUALITY_DESCRIPTION_UNMATCHABLE = "Unmatchable";
		public const string QUALITY_DESCRIPTION_UNKNOWN = "Unknown";

        public static DataTable GetAllQualities()
        {
            DataTable ret = new DataTable();
            ret.Columns.Add(new DataColumn("id", typeof(int)));
            ret.Columns.Add(new DataColumn("name", typeof(string)));
            ret.Columns.Add(new DataColumn("description", typeof(string)));
            ret.Columns.Add(new DataColumn("value", typeof(string)));

            //DataRow row = null;

            foreach (GeocodeQualityType item in Enum.GetValues(typeof(GeocodeQualityType)))
            {
                DataRow row = ret.NewRow();
                row["id"] = (int)item;
                row["name"] = getQualityName(item);
                row["description"] = getQualityDescription(item);
                row["value"] = item.ToString();
                ret.Rows.Add(row);
            }

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ActualLotInterpolation;
            //row["name"] = getQualityName(GeocodeQualityType.ActualLotInterpolation);
            //row["description"] = getQualityDescription(GeocodeQualityType.ActualLotInterpolation);
            //row["value"] = GeocodeQualityType.ActualLotInterpolation;
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.AddressRangeInterpolation;
            //row["name"] = getQualityName(GeocodeQualityType.AddressRangeInterpolation);
            //row["description"] = getQualityDescription(GeocodeQualityType.AddressRangeInterpolation);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.BuildingCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.BuildingCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.BuildingCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.BuildingFrontDoor;
            //row["name"] = getQualityName(GeocodeQualityType.BuildingFrontDoor);
            //row["description"] = getQualityDescription(GeocodeQualityType.BuildingFrontDoor);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.CityCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.CityCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.CityCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.CountryCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.CountryCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.CountryCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.CountyCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.CountyCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.CountyCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.CountySubdivisionCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.CountySubdivisionCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.CountySubdivisionCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ExactParcelCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.ExactParcelCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.ExactParcelCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.DynamicFeatureCompositionCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.DynamicFeatureCompositionCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.DynamicFeatureCompositionCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.GPS;
            //row["name"] = getQualityName(GeocodeQualityType.GPS);
            //row["description"] = getQualityDescription(GeocodeQualityType.GPS);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.NearestParcelCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.NearestParcelCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.NearestParcelCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.StateCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.StateCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.StateCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.StreetCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.StreetCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.StreetCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.StreetIntersection;
            //row["name"] = getQualityName(GeocodeQualityType.StreetIntersection);
            //row["description"] = getQualityDescription(GeocodeQualityType.StreetIntersection);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.UniformLotInterpolation;
            //row["name"] = getQualityName(GeocodeQualityType.UniformLotInterpolation);
            //row["description"] = getQualityDescription(GeocodeQualityType.UniformLotInterpolation);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.Unknown;
            //row["name"] = getQualityName(GeocodeQualityType.Unknown);
            //row["description"] = getQualityDescription(GeocodeQualityType.Unknown);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.Unmatchable;
            //row["name"] = getQualityName(GeocodeQualityType.Unmatchable);
            //row["description"] = getQualityDescription(GeocodeQualityType.Unmatchable);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ZCTACentroid;
            //row["name"] = getQualityName(GeocodeQualityType.ZCTACentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.ZCTACentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ZCTAPlus2Centroid;
            //row["name"] = getQualityName(GeocodeQualityType.ZCTAPlus2Centroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.ZCTAPlus2Centroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ZCTAPlus3Centroid;
            //row["name"] = getQualityName(GeocodeQualityType.ZCTAPlus3Centroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.ZCTAPlus3Centroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ZCTAPlus4Centroid;
            //row["name"] = getQualityName(GeocodeQualityType.ZCTAPlus4Centroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.ZCTAPlus4Centroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.ZCTAPlus5Centroid;
            //row["name"] = getQualityName(GeocodeQualityType.ZCTAPlus5Centroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.ZCTAPlus5Centroid);
            //ret.Rows.Add(row);



            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipAreaCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipAreaCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipAreaCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipPlus2AreaCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipPlus2AreaCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipPlus2AreaCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipPlus3AreaCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipPlus3AreaCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipPlus3AreaCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipPlus4AreaCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipPlus4AreaCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipPlus4AreaCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipPlus5AreaCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipPlus5AreaCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipPlus5AreaCentroid);
            //ret.Rows.Add(row);


            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipPlus4LineCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipPlus4LineCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipPlus4LineCentroid);
            //ret.Rows.Add(row);

            //row = ret.NewRow();
            //row["id"] = (int)GeocodeQualityType.USPSZipPlus5LineCentroid;
            //row["name"] = getQualityName(GeocodeQualityType.USPSZipPlus5LineCentroid);
            //row["description"] = getQualityDescription(GeocodeQualityType.USPSZipPlus5LineCentroid);
            //ret.Rows.Add(row);

            return ret;
        }

		public QualityUtils()
		{
		}

        public static GeocodeQualityType GetQualityTypeFromName(string quality)
        {
            GeocodeQualityType ret = GeocodeQualityType.Unknown;

            if (String.Compare(quality, QUALITY_NAME_ACTUAL_LOT_INTERPOLATION, true) == 0)
            {
                ret = GeocodeQualityType.ActualLotInterpolation;
            }
            else if (String.Compare(quality, QUALITY_NAME_ADDRESS_RANGE_INTERPOLATION, true) == 0)
            {
                ret = GeocodeQualityType.AddressRangeInterpolation;
            }
            else if (String.Compare(quality, QUALITY_NAME_BUILDING_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.BuildingCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_BUILDING_FRONT_DOOR, true) == 0)
            {
                ret = GeocodeQualityType.BuildingFrontDoor;
            }
            else if (String.Compare(quality, QUALITY_NAME_CITY_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.CityCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_CONSOLIDATED_CITY_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ConsolidatedCityCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_COUNTRY_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.CountryCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_COUNTY_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.CountyCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_COUNTY_SUBDIVISION_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.CountySubdivisionCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_DYNAMIC_FEATURE_COMPOSITION_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.DynamicFeatureCompositionCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_EXACT_PARCEL_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ExactParcelCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_GPS, true) == 0)
            {
                ret = GeocodeQualityType.GPS;
            }
            else if (String.Compare(quality, QUALITY_NAME_NEAREST_PARCEL_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.NearestParcelCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_STATE_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.StateCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_STREET_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.StreetCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_STREET_INTERSECTION, true) == 0)
            {
                ret = GeocodeQualityType.StreetIntersection;
            }
            else if (String.Compare(quality, QUALITY_NAME_UNIFORM_LOT_INTERPOLATION, true) == 0)
            {
                ret = GeocodeQualityType.UniformLotInterpolation;
            }
            else if (String.Compare(quality, QUALITY_NAME_UNKNOWN, true) == 0)
            {
                ret = GeocodeQualityType.Unknown;
            }
            else if (String.Compare(quality, QUALITY_NAME_UNMATCHABLE, true) == 0)
            {
                ret = GeocodeQualityType.Unmatchable;
            }

            else if (String.Compare(quality, QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ZCTAPlus1Centroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ZCTAPlus2Centroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ZCTAPlus3Centroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ZCTAPlus4Centroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ZCTAPlus5Centroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_ZIP_CODE_TABULATION_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.ZCTACentroid;
            }

            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus1AreaCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus2AreaCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus3AreaCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus4AreaCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus5AreaCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_AREA_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipAreaCentroid;
            }

            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus4LineCentroid;
            }
            else if (String.Compare(quality, QUALITY_NAME_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID, true) == 0)
            {
                ret = GeocodeQualityType.USPSZipPlus5LineCentroid;
            }

            else
            {
                throw new Exception("Unexpected geocodeQuality: " + quality);
            }
            return ret;
        }

        public static string getQualityName(GeocodeQualityType t)
        {
            string ret = "";
            switch (t)
            {
                case GeocodeQualityType.ActualLotInterpolation:
                    ret = QUALITY_NAME_ACTUAL_LOT_INTERPOLATION;
                    break;
                case GeocodeQualityType.AddressRangeInterpolation:
                    ret = QUALITY_NAME_ADDRESS_RANGE_INTERPOLATION;
                    break;
                case GeocodeQualityType.BuildingCentroid:
                    ret = QUALITY_NAME_BUILDING_CENTROID;
                    break;
                case GeocodeQualityType.BuildingFrontDoor:
                    ret = QUALITY_NAME_BUILDING_FRONT_DOOR;
                    break;
                case GeocodeQualityType.CityCentroid:
                    ret = QUALITY_NAME_CITY_CENTROID;
                    break;
                case GeocodeQualityType.ConsolidatedCityCentroid:
                    ret = QUALITY_NAME_CONSOLIDATED_CITY_CENTROID;
                    break;
                case GeocodeQualityType.CountryCentroid:
                    ret = QUALITY_NAME_COUNTRY_CENTROID;
                    break;
                case GeocodeQualityType.CountyCentroid:
                    ret = QUALITY_NAME_COUNTY_CENTROID;
                    break;
                case GeocodeQualityType.CountySubdivisionCentroid:
                    ret = QUALITY_NAME_COUNTY_SUBDIVISION_CENTROID;
                    break;
                case GeocodeQualityType.DynamicFeatureCompositionCentroid:
                    ret = QUALITY_NAME_DYNAMIC_FEATURE_COMPOSITION_CENTROID;
                    break;
                case GeocodeQualityType.ExactParcelCentroid:
                case GeocodeQualityType.ExactParcelCentroidPoint:
                    ret = QUALITY_NAME_EXACT_PARCEL_CENTROID;
                    break;
                case GeocodeQualityType.GPS:
                    ret = QUALITY_NAME_GPS;
                    break;
                case GeocodeQualityType.NearestParcelCentroid:
                case GeocodeQualityType.NearestParcelCentroidPoint:
                    ret = QUALITY_NAME_NEAREST_PARCEL_CENTROID;
                    break;
                case GeocodeQualityType.StateCentroid:
                    ret = QUALITY_NAME_STATE_CENTROID;
                    break;
                case GeocodeQualityType.StreetCentroid:
                    ret = QUALITY_NAME_STREET_CENTROID;
                    break;
                case GeocodeQualityType.StreetIntersection:
                    ret = QUALITY_NAME_STREET_INTERSECTION;
                    break;
                case GeocodeQualityType.UniformLotInterpolation:
                    ret = QUALITY_NAME_UNIFORM_LOT_INTERPOLATION;
                    break;
                case GeocodeQualityType.Unknown:
                    ret = QUALITY_NAME_UNKNOWN;
                    break;
                case GeocodeQualityType.Unmatchable:
                    ret = QUALITY_NAME_UNMATCHABLE;
                    break;

                case GeocodeQualityType.ZCTACentroid:
                    ret = QUALITY_NAME_ZIP_CODE_TABULATION_AREA_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus1Centroid:
                    ret = QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus2Centroid:
                    ret = QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus3Centroid:
                    ret = QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus4Centroid:
                    ret = QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus5Centroid:
                    ret = QUALITY_NAME_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID;
                    break;

                case GeocodeQualityType.USPSZipAreaCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus1AreaCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus2AreaCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus3AreaCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus4AreaCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus5AreaCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID;
                    break;

                case GeocodeQualityType.USPSZipPlus4LineCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus5LineCentroid:
                    ret = QUALITY_NAME_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID;
                    break;

                    
                default:
                    throw new Exception("Unexpected geocodeQualityType: " + t);
            }
            return ret;
        }

        public static string GetQualityShortName(GeocodeQualityType t)
        {
            string ret = "";
            switch (t)
            {
                case GeocodeQualityType.ActualLotInterpolation:
                    ret = QUALITY_SHORT_NAME_ACTUAL_LOT_INTERPOLATION;
                    break;
                case GeocodeQualityType.AddressRangeInterpolation:
                    ret = QUALITY_SHORT_NAME_ADDRESS_RANGE_INTERPOLATION;
                    break;
                case GeocodeQualityType.BuildingCentroid:
                    ret = QUALITY_SHORT_NAME_BUILDING_CENTROID;
                    break;
                case GeocodeQualityType.BuildingFrontDoor:
                    ret = QUALITY_SHORT_NAME_BUILDING_FRONT_DOOR;
                    break;
                case GeocodeQualityType.CityCentroid:
                    ret = QUALITY_SHORT_NAME_CITY_CENTROID;
                    break;
                case GeocodeQualityType.ConsolidatedCityCentroid:
                    ret = QUALITY_SHORT_NAME_CONSOLIDATED_CITY_CENTROID;
                    break;
                case GeocodeQualityType.CountryCentroid:
                    ret = QUALITY_SHORT_NAME_COUNTRY_CENTROID;
                    break;
                case GeocodeQualityType.CountyCentroid:
                    ret = QUALITY_SHORT_NAME_COUNTY_CENTROID;
                    break;
                case GeocodeQualityType.CountySubdivisionCentroid:
                    ret = QUALITY_SHORT_NAME_COUNTY_SUBDIVISION_CENTROID;
                    break;
                case GeocodeQualityType.DynamicFeatureCompositionCentroid:
                    ret = QUALITY_SHORT_NAME_DYNAMIC_FEATURE_COMPOSITION_CENTROID;
                    break;
                case GeocodeQualityType.ExactParcelCentroid:
                case GeocodeQualityType.ExactParcelCentroidPoint:
                    ret = QUALITY_SHORT_NAME_EXACT_PARCEL_CENTROID;
                    break;
                case GeocodeQualityType.GPS:
                    ret = QUALITY_SHORT_NAME_GPS;
                    break;
                case GeocodeQualityType.NearestParcelCentroid:
                case GeocodeQualityType.NearestParcelCentroidPoint:
                    ret = QUALITY_SHORT_NAME_NEAREST_PARCEL_CENTROID;
                    break;
                case GeocodeQualityType.StateCentroid:
                    ret = QUALITY_SHORT_NAME_STATE_CENTROID;
                    break;
                case GeocodeQualityType.StreetCentroid:
                    ret = QUALITY_SHORT_NAME_STREET_CENTROID;
                    break;
                case GeocodeQualityType.StreetIntersection:
                    ret = QUALITY_SHORT_NAME_STREET_INTERSECTION;
                    break;
                case GeocodeQualityType.UniformLotInterpolation:
                    ret = QUALITY_SHORT_NAME_UNIFORM_LOT_INTERPOLATION;
                    break;
                case GeocodeQualityType.Unknown:
                    ret = QUALITY_SHORT_NAME_UNKNOWN;
                    break;
                case GeocodeQualityType.Unmatchable:
                    ret = QUALITY_SHORT_NAME_UNMATCHABLE;
                    break;

                case GeocodeQualityType.ZCTACentroid:
                    ret = QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus1Centroid:
                    ret = QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus2Centroid:
                    ret = QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus3Centroid:
                    ret = QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus4Centroid:
                    ret = QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus5Centroid:
                    ret = QUALITY_SHORT_NAME_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID;
                    break;

                case GeocodeQualityType.USPSZipAreaCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus1AreaCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus2AreaCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus3AreaCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus4AreaCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus5AreaCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID;
                    break;

                case GeocodeQualityType.USPSZipPlus4LineCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus5LineCentroid:
                    ret = QUALITY_SHORT_NAME_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID;
                    break;
                default:
                    throw new Exception("Unexpected geocodeQualityType: " + t);
            }
            return ret;
        }

        public static string getQualityDescription(GeocodeQualityType t)
        {
            string ret = "";
            switch (t)
            {
                case GeocodeQualityType.ActualLotInterpolation:
                    ret = QUALITY_DESCRIPTION_ACTUAL_LOT_INTERPOLATION;
                    break;
                case GeocodeQualityType.AddressRangeInterpolation:
                    ret = QUALITY_DESCRIPTION_ADDRESS_RANGE_INTERPOLATION;
                    break;
                case GeocodeQualityType.BuildingCentroid:
                    ret = QUALITY_DESCRIPTION_BUILDING_CENTROID;
                    break;
                case GeocodeQualityType.BuildingFrontDoor:
                    ret = QUALITY_DESCRIPTION_BUILDING_FRONT_DOOR;
                    break;
                case GeocodeQualityType.CityCentroid:
                    ret = QUALITY_DESCRIPTION_CITY_CENTROID;
                    break;
                case GeocodeQualityType.ConsolidatedCityCentroid:
                    ret = QUALITY_DESCRIPTION_CONSOLIDATED_CITY_CENTROID;
                    break;
                case GeocodeQualityType.CountryCentroid:
                    ret = QUALITY_DESCRIPTION_COUNTRY_CENTROID;
                    break;
                case GeocodeQualityType.CountyCentroid:
                    ret = QUALITY_DESCRIPTION_COUNTY_CENTROID;
                    break;
                case GeocodeQualityType.CountySubdivisionCentroid:
                    ret = QUALITY_DESCRIPTION_COUNTY_SUBDIVISION_CENTROID;
                    break;
                case GeocodeQualityType.DynamicFeatureCompositionCentroid:
                    ret = QUALITY_DESCRIPTION_DYNAMIC_FEATURE_COMPOSITION_CENTROID;
                    break;
                case GeocodeQualityType.ExactParcelCentroid:
                case GeocodeQualityType.ExactParcelCentroidPoint:
                    ret = QUALITY_DESCRIPTION_EXACT_PARCEL_CENTROID;
                    break;
                case GeocodeQualityType.GPS:
                    ret = QUALITY_DESCRIPTION_GPS;
                    break;
                case GeocodeQualityType.NearestParcelCentroid:
                case GeocodeQualityType.NearestParcelCentroidPoint:
                    ret = QUALITY_DESCRIPTION_NEAREST_PARCEL_CENTROID;
                    break;
                case GeocodeQualityType.StateCentroid:
                    ret = QUALITY_DESCRIPTION_STATE_CENTROID;
                    break;
                case GeocodeQualityType.StreetCentroid:
                    ret = QUALITY_DESCRIPTION_STREET_CENTROID;
                    break;
                case GeocodeQualityType.StreetIntersection:
                    ret = QUALITY_DESCRIPTION_STREET_INTERSECTION;
                    break;
                case GeocodeQualityType.UniformLotInterpolation:
                    ret = QUALITY_DESCRIPTION_UNIFORM_LOT_INTERPOLATION;
                    break;
                case GeocodeQualityType.Unknown:
                    ret = QUALITY_DESCRIPTION_UNKNOWN;
                    break;
                case GeocodeQualityType.Unmatchable:
                    ret = QUALITY_DESCRIPTION_UNMATCHABLE;
                    break;
                case GeocodeQualityType.ZCTACentroid:
                    ret = QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus1Centroid:
                    ret = QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_1_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus2Centroid:
                    ret = QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_2_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus3Centroid:
                    ret = QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_3_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus4Centroid:
                    ret = QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_4_CENTROID;
                    break;
                case GeocodeQualityType.ZCTAPlus5Centroid:
                    ret = QUALITY_DESCRIPTION_ZIP_CODE_TABULATION_AREA_PLUS_5_CENTROID;
                    break;

                case GeocodeQualityType.USPSZipAreaCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus1AreaCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_1_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus2AreaCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_2_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus3AreaCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_3_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus4AreaCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_4_AREA_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus5AreaCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_5_AREA_CENTROID;
                    break;

                case GeocodeQualityType.USPSZipPlus4LineCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_4_LINE_CENTROID;
                    break;
                case GeocodeQualityType.USPSZipPlus5LineCentroid:
                    ret = QUALITY_DESCRIPTION_USPS_ZIP_CODE_PLUS_5_LINE_CENTROID;
                    break;
                default:
                    throw new Exception("Unexpected geocodeQualityType: " + t);
            }
            return ret;
        }
	}
}
