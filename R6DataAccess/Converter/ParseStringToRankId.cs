using R6Sharp.Response.Static;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace R6DataAccess.Converter
{
    public class ParseStringToRankId : JsonConverter<RankId>
    {
     
            public override RankId Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    if (Enum.TryParse(reader.GetString(), true, out RankId id))
                    {
                        return id;
                    }
                }

                return Enum.Parse<RankId>(reader.GetString());
            }

            public override void Write(Utf8JsonWriter writer, RankId value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToString());
            }
       

    }
}
