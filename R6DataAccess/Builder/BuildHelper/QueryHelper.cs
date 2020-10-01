using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.Json.Serialization;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;

namespace R6DataAccess.Builder.BuildHelper
{
    public static class QueryHelper
    {

        private static IQuery _query;
        private static IEndPoints _endPoints;

        // this could  go into queryBuilder
        public static string GetQueryString(IQuery query, IEndPoints endPoints)
        {

            _query = query;
            _endPoints = endPoints;



            var queryString = "";

            foreach(var property in query.GetType().GetProperties())
            {

                var propValue = property.GetValue(query);

               


                if (propValue != null)
                {
                    var type = property.PropertyType;


                
                   

                     var propertyName = GetJsonPropertyValue(property);
                     var propertyValue = GetPropertyValue(type, propValue);

                    if (propertyValue != null)
                    {

                        queryString += $"{propertyName}={propertyValue}&";
                    }
                    

                }

            }


            return cleanUpQueryString(queryString);
        }

     

        // as properties get bigger made this method to remove last char as supposed to 
        private static string cleanUpQueryString(string query)
        {

            var lengthOfQuery = query.Length;

            var lastIndex = lengthOfQuery - 1;

            char lastCharInQuery = query[lastIndex];

            if (lastCharInQuery.Equals('&'))
            {
                return query.Remove(lastIndex);
            }




            return query;
        }


    

        private static string GetJsonPropertyValue(PropertyInfo property)
        {

            var jsonPropertyArray = property.GetCustomAttributes(typeof(JsonPropertyNameAttribute), true);

            //get first array 
            var firstAttributes = (JsonPropertyNameAttribute)jsonPropertyArray[0];

            return firstAttributes.Name;
        }

        private static  string GetPropertyValue(Type type, object propertyValue)
        {
            string propStringValue;
            // would need refactoring if there are any other way
     
            /// would need to change it so object are casted at run time
            /// should be able to rewrite later on 
            /// 
            if (type == typeof(IPlatform))
            {
                //endpoint doesnt need the platform values

                if (!_endPoints.Name.Equals(EndPoints.Statistics.Name))
                {
                    var platform = (IPlatform)propertyValue;

                    propStringValue = platform.Name;
                }
                else
                {

                    return null;
                }
            }
            else if (type == typeof(IRegion))
            {
                var platform = (IRegion)propertyValue;

                propStringValue = platform.Name;
            }
            else
            {

                propStringValue = propertyValue.ToString();
            }


            return propStringValue;
        }
    }
}
