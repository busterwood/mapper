﻿using System;
using System.Collections;
using System.Data;
using System.Data.Common;

namespace BusterWood.Mapper.UnitTests
{
    class StubDataReader : DbDataReader
    {
        public string[] Names;
        public Type[] Types;
        public object[] Values;
        internal int ReadCalled;
        internal int RecordCount = 1;
        public string[] DataTypeNames;

        public override string GetName(int i) => Names[i];
        public override Type GetFieldType(int i) => Types[i];
        public override object GetValue(int i) => Values[i];
        public override short GetInt16(int i) => (short)Values[i];
        public override int GetInt32(int i) => (int)Values[i];
        public override long GetInt64(int i) => (long)Values[i];
        public override float GetFloat(int i) => (float)Values[i];
        public override double GetDouble(int i) => (double)Values[i];
        public override string GetString(int i) => (string)Values[i];
        public override decimal GetDecimal(int i) => (decimal)Values[i];
        public override Guid GetGuid(int i) => (Guid)Values[i];
        public override DateTime GetDateTime(int i) => (DateTime)Values[i];
        public override bool IsDBNull(int i) => Values[i] is DBNull;
        public override string GetDataTypeName(int i) => DataTypeNames == null ? "" : DataTypeNames[i];

        public override IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override int GetOrdinal(string name)
        {
            throw new NotImplementedException();
        }

        public override bool GetBoolean(int ordinal)
        {
            throw new NotImplementedException();
        }

        public override byte GetByte(int ordinal)
        {
            throw new NotImplementedException();
        }

        public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
        {
            throw new NotImplementedException();
        }

        public override char GetChar(int ordinal)
        {
            throw new NotImplementedException();
        }

        public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
        {
            throw new NotImplementedException();
        }

        public override int GetValues(object[] copyTo)
        {
            Values.CopyTo(copyTo, 0);
            return copyTo.Length <= Values.Length ? copyTo.Length : Values.Length;
        }

        public override bool NextResult()
        {
            return false;
        }

        public override bool Read()
        {
            ReadCalled++;
            return ReadCalled <= RecordCount;
        }

        public override void Close()
        {
        }

        public override DataTable GetSchemaTable()
        {
            throw new NotImplementedException();
        }

        public override int FieldCount => Names.Length;
        public override int Depth => 0;
        public override bool IsClosed => false;
        public override int RecordsAffected => 0;

        public override bool HasRows
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override object this[string name]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override object this[int ordinal]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
    
}