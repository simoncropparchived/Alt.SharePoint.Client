
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class JsonReaderMock : JsonReader
    {


        public override Microsoft.SharePoint.Client.ClientRuntimeContext Context => ContextEx;
        public Microsoft.SharePoint.Client.ClientRuntimeContext ContextEx { get; set; }

        public override System.Boolean ReadBoolean()
        {
            return ReadBooleanEx;
        }
        public System.Boolean ReadBooleanEx { get; set;}

        public override System.Byte ReadByte()
        {
            return ReadByteEx;
        }
        public System.Byte ReadByteEx { get; set;}

        public override System.Char ReadChar()
        {
            return ReadCharEx;
        }
        public System.Char ReadCharEx { get; set;}

        public override System.Int16 ReadInt16()
        {
            return ReadInt16Ex;
        }
        public System.Int16 ReadInt16Ex { get; set;}

        public override System.UInt16 ReadUInt16()
        {
            return ReadUInt16Ex;
        }
        public System.UInt16 ReadUInt16Ex { get; set;}

        public override System.Int32 ReadInt32()
        {
            return ReadInt32Ex;
        }
        public System.Int32 ReadInt32Ex { get; set;}

        public override System.UInt32 ReadUInt32()
        {
            return ReadUInt32Ex;
        }
        public System.UInt32 ReadUInt32Ex { get; set;}

        public override System.Int64 ReadInt64()
        {
            return ReadInt64Ex;
        }
        public System.Int64 ReadInt64Ex { get; set;}

        public override System.UInt64 ReadUInt64()
        {
            return ReadUInt64Ex;
        }
        public System.UInt64 ReadUInt64Ex { get; set;}

        public override System.Single ReadSingle()
        {
            return ReadSingleEx;
        }
        public System.Single ReadSingleEx { get; set;}

        public override System.Double ReadDouble()
        {
            return ReadDoubleEx;
        }
        public System.Double ReadDoubleEx { get; set;}

        public override System.Decimal ReadDecimal()
        {
            return ReadDecimalEx;
        }
        public System.Decimal ReadDecimalEx { get; set;}

        public override System.TimeSpan ReadTimeSpan()
        {
            return ReadTimeSpanEx;
        }
        public System.TimeSpan ReadTimeSpanEx { get; set;}

        public override System.DateTime ReadDateTime()
        {
            return ReadDateTimeEx;
        }
        public System.DateTime ReadDateTimeEx { get; set;}

        public override System.Guid ReadGuid()
        {
            return ReadGuidEx;
        }
        public System.Guid ReadGuidEx { get; set;}

        public override System.Byte[] ReadByteArray()
        {
            return ReadByteArrayEx;
        }
        public System.Byte[] ReadByteArrayEx { get; set;}

        public override System.IO.Stream ReadStream()
        {
            return ReadStreamEx;
        }
        public System.IO.Stream ReadStreamEx { get; set;}

        public override System.String ReadString()
        {
            return ReadStringEx;
        }
        public System.String ReadStringEx { get; set;}

        public override Microsoft.SharePoint.Client.JsonTokenType PeekTokenType()
        {
            return PeekTokenTypeEx;
        }
        public Microsoft.SharePoint.Client.JsonTokenType PeekTokenTypeEx { get; set;}

        public override void ReadArrayStart()
        {
        }

        public override void ReadArrayEnd()
        {
        }

        public override void ReadObjectStart()
        {
        }

        public override System.String ReadName()
        {
            return ReadNameEx;
        }
        public System.String ReadNameEx { get; set;}

        public override System.String PeekName()
        {
            return PeekNameEx;
        }
        public System.String PeekNameEx { get; set;}

        public override void ReadObjectEnd()
        {
        }

        public override System.Boolean[] ReadBooleanArray()
        {
            return ReadBooleanArrayEx;
        }
        public System.Boolean[] ReadBooleanArrayEx { get; set;}

        public override System.Int16[] ReadInt16Array()
        {
            return ReadInt16ArrayEx;
        }
        public System.Int16[] ReadInt16ArrayEx { get; set;}

        public override System.UInt16[] ReadUInt16Array()
        {
            return ReadUInt16ArrayEx;
        }
        public System.UInt16[] ReadUInt16ArrayEx { get; set;}

        public override System.Int32[] ReadInt32Array()
        {
            return ReadInt32ArrayEx;
        }
        public System.Int32[] ReadInt32ArrayEx { get; set;}

        public override System.UInt32[] ReadUInt32Array()
        {
            return ReadUInt32ArrayEx;
        }
        public System.UInt32[] ReadUInt32ArrayEx { get; set;}

        public override System.Int64[] ReadInt64Array()
        {
            return ReadInt64ArrayEx;
        }
        public System.Int64[] ReadInt64ArrayEx { get; set;}

        public override System.UInt64[] ReadUInt64Array()
        {
            return ReadUInt64ArrayEx;
        }
        public System.UInt64[] ReadUInt64ArrayEx { get; set;}

        public override System.Single[] ReadSingleArray()
        {
            return ReadSingleArrayEx;
        }
        public System.Single[] ReadSingleArrayEx { get; set;}

        public override System.Double[] ReadDoubleArray()
        {
            return ReadDoubleArrayEx;
        }
        public System.Double[] ReadDoubleArrayEx { get; set;}

        public override System.Decimal[] ReadDecimalArray()
        {
            return ReadDecimalArrayEx;
        }
        public System.Decimal[] ReadDecimalArrayEx { get; set;}

        public override System.TimeSpan[] ReadTimeSpanArray()
        {
            return ReadTimeSpanArrayEx;
        }
        public System.TimeSpan[] ReadTimeSpanArrayEx { get; set;}

        public override System.DateTime[] ReadDateTimeArray()
        {
            return ReadDateTimeArrayEx;
        }
        public System.DateTime[] ReadDateTimeArrayEx { get; set;}

        public override System.Guid[] ReadGuidArray()
        {
            return ReadGuidArrayEx;
        }
        public System.Guid[] ReadGuidArrayEx { get; set;}

        public override System.String[] ReadStringArray()
        {
            return ReadStringArrayEx;
        }
        public System.String[] ReadStringArrayEx { get; set;}

        public override System.Collections.Specialized.StringCollection ReadStringCollection()
        {
            return ReadStringCollectionEx;
        }
        public System.Collections.Specialized.StringCollection ReadStringCollectionEx { get; set;}

        public override System.Collections.Generic.Dictionary<System.String, System.Object> ReadDictionary()
        {
            return ReadDictionaryEx;
        }
        public System.Collections.Generic.Dictionary<System.String, System.Object> ReadDictionaryEx { get; set;}

        public override System.Collections.Generic.KeyValuePair<System.String, System.Object> ReadKeyValue()
        {
            return ReadKeyValueEx;
        }
        public System.Collections.Generic.KeyValuePair<System.String, System.Object> ReadKeyValueEx { get; set;}

        public override System.Object ReadObject()
        {
            return ReadObjectEx;
        }
        public System.Object ReadObjectEx { get; set;}

        public override System.Object[] ReadObjectArray()
        {
            return ReadObjectArrayEx;
        }
        public System.Object[] ReadObjectArrayEx { get; set;}

        public override void Dispose()
        {
        }

    }
}

