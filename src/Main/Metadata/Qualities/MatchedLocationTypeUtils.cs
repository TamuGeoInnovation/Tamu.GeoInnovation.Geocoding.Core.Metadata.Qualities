using System;
using System.Data;
using USC.GISResearchLab.Geocoding.Core.Metadata.Qualities;

namespace USC.GISResearchLab.Geocoding.Core.Utils.Qualities
{
    /// <summary>
    /// Summary description for MatchedLocationTypeUtils.
    /// </summary>
    public class MatchedLocationTypeUtils
    {

        public const string MATCHED_LOCATION_TYPE_NAME_UNKNOWN = "LOCATION_TYPE_UNKNOWN";
        public const string MATCHED_LOCATION_TYPE_NAME_STREET_ADDRESS = "LOCATION_TYPE_STREET_ADDRESS";
        public const string MATCHED_LOCATION_TYPE_NAME_POST_OFFICE_BOX = "LOCATION_TYPE_POST_OFFICE_BOX";
        public const string MATCHED_LOCATION_TYPE_NAME_RURAL_ROUTE = "LOCATION_TYPE_RURAL_ROUTE";
        public const string MATCHED_LOCATION_TYPE_NAME_STAR_ROUTE = "LOCATION_TYPE_STAR_ROUTE";
        public const string MATCHED_LOCATION_TYPE_NAME_HIGHWAY_CONTRACT_ROUTE = "LOCATION_TYPE_HIGHWAY_CONTRACT_ROUTE";
        public const string MATCHED_LOCATION_TYPE_NAME_INTERSECTION = "LOCATION_TYPE_INTERSECTION";
        public const string MATCHED_LOCATION_TYPE_NAME_NAMED_PLACE = "LOCATION_TYPE_NAMED_PLACE";
        public const string MATCHED_LOCATION_TYPE_NAME_RELATIVE_DIRECTION = "LOCATION_TYPE_RELATIVE_DIRECTION";
        public const string MATCHED_LOCATION_TYPE_NAME_USPS_ZIP_CODE = "LOCATION_TYPE_USPS_ZIP_CODE";
        public const string MATCHED_LOCATION_TYPE_NAME_CITY = "LOCATION_TYPE_CITY";
        public const string MATCHED_LOCATION_TYPE_NAME_STATE = "LOCATION_TYPE_STATE";
        public const string MATCHED_LOCATION_TYPE_NAME_UNMATCHABLE = "LOCATION_TYPE_UNMATCHABLE";


        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_UNKNOWN = "unknown";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_STREET_ADDRESS = "street address";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_POST_OFFICE_BOX = "po box";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_RURAL_ROUTE = "rural rte";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_STAR_ROUTE = "star rte";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_HIGHWAY_CONTRACT_ROUTE = "hwy contract rte";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_INTERSECTION = "intersection";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_NAMED_PLACE = "named place";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_RELATIVE_DIRECTION = "relative direction";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_USPS_ZIP_CODE = "zip";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_CITY = "city";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_STATE = "state";
        public const string MATCHED_LOCATION_TYPE_SHORT_NAME_UNMATCHABLE = "unmatchable";



        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_UNKNOWN = "Unknown";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_STREET_ADDRESS = "Street address";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_POST_OFFICE_BOX = "Post Office Box";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_RURAL_ROUTE = "Rural Route";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_STAR_ROUTE = "Star Route";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_HIGHWAY_CONTRACT_ROUTE = "Highway Contract Route";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_INTERSECTION = "Intersection";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_NAMED_PLACE = "Named place";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_RELATIVE_DIRECTION = "Relative direction";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_USPS_ZIP_CODE = "USPS ZIP Code";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_CITY = "City";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_STATE = "state";
        public const string MATCHED_LOCATION_TYPE_DESCRIPTION_UNMATCHABLE = "Unmatchable";



        public static DataTable GetAllMatchedLocationTypes()
        {
            DataTable ret = new DataTable();
            ret.Columns.Add(new DataColumn("id", typeof(int)));
            ret.Columns.Add(new DataColumn("name", typeof(string)));
            ret.Columns.Add(new DataColumn("description", typeof(string)));
            ret.Columns.Add(new DataColumn("value", typeof(string)));

            foreach (MatchedLocationTypes item in Enum.GetValues(typeof(MatchedLocationTypes)))
            {
                DataRow row = ret.NewRow();
                row["id"] = (int)item;
                row["name"] = GetMatchedLocationTypeName(item);
                row["description"] = GetMatchedLocationTypeDescription(item);
                row["value"] = item.ToString();
                ret.Rows.Add(row);
            }

            return ret;
        }

        public MatchedLocationTypeUtils()
        {
        }

        public static MatchedLocationTypes GetQualityTypeFromName(string matchLocationType)
        {
            MatchedLocationTypes ret = MatchedLocationTypes.Unknown;

            if (!String.IsNullOrEmpty(matchLocationType))
            {
                if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_CITY, true) == 0)
                {
                    ret = MatchedLocationTypes.City;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_HIGHWAY_CONTRACT_ROUTE, true) == 0)
                {
                    ret = MatchedLocationTypes.HighwayContractRoute;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_INTERSECTION, true) == 0)
                {
                    ret = MatchedLocationTypes.Intersection;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_NAMED_PLACE, true) == 0)
                {
                    ret = MatchedLocationTypes.NamedPlace;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_POST_OFFICE_BOX, true) == 0)
                {
                    ret = MatchedLocationTypes.PostOfficeBox;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_RELATIVE_DIRECTION, true) == 0)
                {
                    ret = MatchedLocationTypes.RelativeDirection;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_RURAL_ROUTE, true) == 0)
                {
                    ret = MatchedLocationTypes.RuralRoute;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_STAR_ROUTE, true) == 0)
                {
                    ret = MatchedLocationTypes.StarRoute;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_STATE, true) == 0)
                {
                    ret = MatchedLocationTypes.State;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_STREET_ADDRESS, true) == 0)
                {
                    ret = MatchedLocationTypes.StreetAddress;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_UNKNOWN, true) == 0)
                {
                    ret = MatchedLocationTypes.Unknown;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_UNMATCHABLE, true) == 0)
                {
                    ret = MatchedLocationTypes.Unmatchable;
                }
                else if (String.Compare(matchLocationType, MATCHED_LOCATION_TYPE_NAME_USPS_ZIP_CODE, true) == 0)
                {
                    ret = MatchedLocationTypes.USPSZIP;
                }
                else
                {
                    throw new Exception("Unexpected MatchedLocationTypes: " + matchLocationType);
                }
            }
            return ret;
        }

        public static string GetMatchedLocationTypeName(MatchedLocationTypes t)
        {
            string ret = "";
            switch (t)
            {
                case MatchedLocationTypes.City:
                    ret = MATCHED_LOCATION_TYPE_NAME_CITY;
                    break;
                case MatchedLocationTypes.HighwayContractRoute:
                    ret = MATCHED_LOCATION_TYPE_NAME_HIGHWAY_CONTRACT_ROUTE;
                    break;
                case MatchedLocationTypes.Intersection:
                    ret = MATCHED_LOCATION_TYPE_NAME_INTERSECTION;
                    break;
                case MatchedLocationTypes.NamedPlace:
                    ret = MATCHED_LOCATION_TYPE_NAME_NAMED_PLACE;
                    break;
                case MatchedLocationTypes.PostOfficeBox:
                    ret = MATCHED_LOCATION_TYPE_NAME_POST_OFFICE_BOX;
                    break;
                case MatchedLocationTypes.RelativeDirection:
                    ret = MATCHED_LOCATION_TYPE_NAME_RELATIVE_DIRECTION;
                    break;
                case MatchedLocationTypes.RuralRoute:
                    ret = MATCHED_LOCATION_TYPE_NAME_RURAL_ROUTE;
                    break;
                case MatchedLocationTypes.StarRoute:
                    ret = MATCHED_LOCATION_TYPE_NAME_STAR_ROUTE;
                    break;
                case MatchedLocationTypes.State:
                    ret = MATCHED_LOCATION_TYPE_NAME_STATE;
                    break;
                case MatchedLocationTypes.StreetAddress:
                    ret = MATCHED_LOCATION_TYPE_NAME_STREET_ADDRESS;
                    break;
                case MatchedLocationTypes.Unknown:
                    ret = MATCHED_LOCATION_TYPE_NAME_UNKNOWN;
                    break;
                case MatchedLocationTypes.Unmatchable:
                    ret = MATCHED_LOCATION_TYPE_NAME_UNMATCHABLE;
                    break;
                case MatchedLocationTypes.USPSZIP:
                    ret = MATCHED_LOCATION_TYPE_NAME_USPS_ZIP_CODE;
                    break;
                default:
                    throw new Exception("Unexpected MatchedLocationTypes: " + t);
            }
            return ret;
        }

        public static string GetMatchedLocationTypeShortName(MatchedLocationTypes t)
        {
            string ret = "";
            switch (t)
            {
                case MatchedLocationTypes.City:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_CITY;
                    break;
                case MatchedLocationTypes.HighwayContractRoute:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_HIGHWAY_CONTRACT_ROUTE;
                    break;
                case MatchedLocationTypes.Intersection:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_INTERSECTION;
                    break;
                case MatchedLocationTypes.NamedPlace:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_NAMED_PLACE;
                    break;
                case MatchedLocationTypes.PostOfficeBox:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_POST_OFFICE_BOX;
                    break;
                case MatchedLocationTypes.RelativeDirection:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_RELATIVE_DIRECTION;
                    break;
                case MatchedLocationTypes.RuralRoute:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_RURAL_ROUTE;
                    break;
                case MatchedLocationTypes.StarRoute:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_STAR_ROUTE;
                    break;
                case MatchedLocationTypes.State:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_STATE;
                    break;
                case MatchedLocationTypes.StreetAddress:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_STREET_ADDRESS;
                    break;
                case MatchedLocationTypes.Unknown:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_UNKNOWN;
                    break;
                case MatchedLocationTypes.Unmatchable:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_UNMATCHABLE;
                    break;
                case MatchedLocationTypes.USPSZIP:
                    ret = MATCHED_LOCATION_TYPE_SHORT_NAME_USPS_ZIP_CODE;
                    break;
                default:
                    throw new Exception("Unexpected MatchedLocationTypes: " + t);
            }
            return ret;
        }

        public static string GetMatchedLocationTypeDescription(MatchedLocationTypes t)
        {
            string ret = "";
            switch (t)
            {
                case MatchedLocationTypes.City:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_CITY;
                    break;
                case MatchedLocationTypes.HighwayContractRoute:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_HIGHWAY_CONTRACT_ROUTE;
                    break;
                case MatchedLocationTypes.Intersection:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_INTERSECTION;
                    break;
                case MatchedLocationTypes.NamedPlace:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_NAMED_PLACE;
                    break;
                case MatchedLocationTypes.PostOfficeBox:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_POST_OFFICE_BOX;
                    break;
                case MatchedLocationTypes.RelativeDirection:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_RELATIVE_DIRECTION;
                    break;
                case MatchedLocationTypes.RuralRoute:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_RURAL_ROUTE;
                    break;
                case MatchedLocationTypes.StarRoute:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_STAR_ROUTE;
                    break;
                case MatchedLocationTypes.State:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_STATE;
                    break;
                case MatchedLocationTypes.StreetAddress:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_STREET_ADDRESS;
                    break;
                case MatchedLocationTypes.Unknown:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_UNKNOWN;
                    break;
                case MatchedLocationTypes.Unmatchable:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_UNMATCHABLE;
                    break;
                case MatchedLocationTypes.USPSZIP:
                    ret = MATCHED_LOCATION_TYPE_DESCRIPTION_USPS_ZIP_CODE;
                    break;
                default:
                    throw new Exception("Unexpected MatchedLocationTypes: " + t);
            }
            return ret;
        }
    }
}
